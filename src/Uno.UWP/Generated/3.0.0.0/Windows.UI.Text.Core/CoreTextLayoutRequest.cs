#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreTextLayoutRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsCanceled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreTextLayoutRequest.IsCanceled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CoreTextLayoutRequest.IsCanceled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.Core.CoreTextLayoutBounds LayoutBounds
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextLayoutBounds CoreTextLayoutRequest.LayoutBounds is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreTextLayoutBounds%20CoreTextLayoutRequest.LayoutBounds");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.Core.CoreTextRange Range
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextRange CoreTextLayoutRequest.Range is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreTextRange%20CoreTextLayoutRequest.Range");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Text.Core.CoreTextLayoutBounds LayoutBoundsVisualPixels
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreTextLayoutBounds CoreTextLayoutRequest.LayoutBoundsVisualPixels is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreTextLayoutBounds%20CoreTextLayoutRequest.LayoutBoundsVisualPixels");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextLayoutRequest.Range.get
		// Forced skipping of method Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBounds.get
		// Forced skipping of method Windows.UI.Text.Core.CoreTextLayoutRequest.IsCanceled.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CoreTextLayoutRequest.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20CoreTextLayoutRequest.GetDeferral%28%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextLayoutRequest.LayoutBoundsVisualPixels.get
	}
}
