#nullable enable

using System;
using System.Collections.Generic;
using System.Numerics;
using SkiaSharp;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Uno.Extensions;

namespace Windows.UI.Composition;

public partial class Compositor
{

	private readonly Stack<Filter> _filterStack = new();
	private Filter _currentFilter = Filter.Default;

	private bool _isDirty;
	
	internal Filter CurrentFilter => _currentFilter;

	internal void RenderRootVisual(SKSurface surface, ContainerVisual rootVisual)
	{
		if (rootVisual is null)
		{
			throw new ArgumentNullException(nameof(rootVisual));
		}

		_isDirty = false;

		var children = rootVisual.GetChildrenInRenderOrder();
		for (var i = 0; i < children.Count; i++)
		{
			RenderVisual(surface, children[i]);
		}
	}

	internal void RenderVisual(SKSurface surface, Visual visual)
	{
		if (visual is { Opacity: 0 } or { IsVisible: false })
		{
			return;
		}

		if (visual.ShadowState is { } shadow)
		{
			surface.Canvas.SaveLayer(shadow.Paint);
		}
		else
		{
			surface.Canvas.Save();
		}

		// Set the position of the visual on the canvas (i.e. change coordinates system to the "XAML element" one)
		surface.Canvas.Translate(visual.Offset.X + visual.AnchorPoint.X, visual.Offset.Y + visual.AnchorPoint.Y);

		// Applied rending transformation matrix (i.e. change coordinates system to the "rendering" one)
		if (visual.GetTransform() is { IsIdentity: false } transform)
		{
			var skTransform = transform.ToSKMatrix();
			surface.Canvas.Concat(ref skTransform);
		}

		// Apply the clipping defined on the element
		// (Only the Clip property, clipping applied by parent for layout constraints reason it's managed by the ShapeVisual through the ViewBox)
		// Note: The Clip is applied after the transformation matrix, so it's also transformed.
		visual.Clip?.Apply(surface);

		using var filter = PushFilter(visual.Opacity);

		visual.Render(surface);

		surface.Canvas.Restore();
	}


	partial void InvalidateRenderPartial()
	{
		if (!_isDirty)
		{
			_isDirty = true;
			// TODO: Adjust for multi window #8341 
			CoreApplication.QueueInvalidateRender();
		}
	}

	private FilterDisposable PushFilter(float opacity)
	{
		if (opacity is 1.0f)
		{
			// This won't change anything, to not increase effect stack size for nothing
			return default;
		}

		_filterStack.Push(_currentFilter);

		_currentFilter = _currentFilter with
		{
			Opacity = _currentFilter.Opacity * opacity
		};

		return new FilterDisposable(this);
	}

	/// <summary>
	/// A holding struct for effects that should be applied by children instead of visual itself, usually only on actual drawing instead of container visual.
	/// </summary>
	/// <param name="Opacity">
	///		The opacity to apply to children.
	///		This should be applied only on drawing and not the container to avoid fade-ou of child containers.
	/// </param>
	internal record struct Filter(float Opacity)
	{
		public static Filter Default { get; } = new(1.0f);

		private SKColorFilter? _opacityColorFilter = null;

		// Note: This SKColorFilter might be created more than once since this Filter is a struct.
		//       However since this Filter is copied (pushed to the stack) only when something changes, it should still catch most cases.
		public SKColorFilter? OpacityColorFilter => Opacity is 1.0f
			? null
			: _opacityColorFilter ??= SKColorFilter.CreateBlendMode(new SKColor(0xFF, 0xFF, 0xFF, (byte)(255 * Opacity)), SKBlendMode.Modulate);
	}

	private readonly record struct FilterDisposable(Compositor Compositor) : IDisposable
	{
		public void Dispose()
		{
			if (Compositor is null) // nop filter!
			{
				return;
			}

			Compositor._currentFilter = Compositor._filterStack.Pop();
		}
	}
}
