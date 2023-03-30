#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Input
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class TouchCapabilities 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint Contacts
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint TouchCapabilities.Contacts is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20TouchCapabilities.Contacts");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int TouchPresent
		{
			get
			{
				throw new global::System.NotImplementedException("The member int TouchCapabilities.TouchPresent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20TouchCapabilities.TouchPresent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public TouchCapabilities() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Input.TouchCapabilities", "TouchCapabilities.TouchCapabilities()");
		}
		#endif
		// Forced skipping of method Windows.Devices.Input.TouchCapabilities.TouchCapabilities()
		// Forced skipping of method Windows.Devices.Input.TouchCapabilities.TouchPresent.get
		// Forced skipping of method Windows.Devices.Input.TouchCapabilities.Contacts.get
	}
}
