#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.SerialCommunication
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ErrorReceivedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.SerialCommunication.SerialError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member SerialError ErrorReceivedEventArgs.Error is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SerialError%20ErrorReceivedEventArgs.Error");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.SerialCommunication.ErrorReceivedEventArgs.Error.get
	}
}
