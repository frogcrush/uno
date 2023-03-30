#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreInputViewOcclusion 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Rect OccludingRect
		{
			get
			{
				throw new global::System.NotImplementedException("The member Rect CoreInputViewOcclusion.OccludingRect is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Rect%20CoreInputViewOcclusion.OccludingRect");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.ViewManagement.Core.CoreInputViewOcclusionKind OcclusionKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreInputViewOcclusionKind CoreInputViewOcclusion.OcclusionKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreInputViewOcclusionKind%20CoreInputViewOcclusion.OcclusionKind");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OccludingRect.get
		// Forced skipping of method Windows.UI.ViewManagement.Core.CoreInputViewOcclusion.OcclusionKind.get
	}
}
