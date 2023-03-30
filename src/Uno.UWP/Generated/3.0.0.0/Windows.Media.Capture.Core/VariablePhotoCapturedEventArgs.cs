#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VariablePhotoCapturedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan CaptureTimeOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan VariablePhotoCapturedEventArgs.CaptureTimeOffset is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20VariablePhotoCapturedEventArgs.CaptureTimeOffset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Capture.CapturedFrameControlValues CapturedFrameControlValues
		{
			get
			{
				throw new global::System.NotImplementedException("The member CapturedFrameControlValues VariablePhotoCapturedEventArgs.CapturedFrameControlValues is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CapturedFrameControlValues%20VariablePhotoCapturedEventArgs.CapturedFrameControlValues");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Capture.CapturedFrame Frame
		{
			get
			{
				throw new global::System.NotImplementedException("The member CapturedFrame VariablePhotoCapturedEventArgs.Frame is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CapturedFrame%20VariablePhotoCapturedEventArgs.Frame");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint? UsedFrameControllerIndex
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint? VariablePhotoCapturedEventArgs.UsedFrameControllerIndex is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%3F%20VariablePhotoCapturedEventArgs.UsedFrameControllerIndex");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs.Frame.get
		// Forced skipping of method Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs.CaptureTimeOffset.get
		// Forced skipping of method Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs.UsedFrameControllerIndex.get
		// Forced skipping of method Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs.CapturedFrameControlValues.get
	}
}
