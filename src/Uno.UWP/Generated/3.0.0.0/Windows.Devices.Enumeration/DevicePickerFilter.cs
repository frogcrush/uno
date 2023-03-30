#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DevicePickerFilter 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.Devices.Enumeration.DeviceClass> SupportedDeviceClasses
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<DeviceClass> DevicePickerFilter.SupportedDeviceClasses is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3CDeviceClass%3E%20DevicePickerFilter.SupportedDeviceClasses");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<string> SupportedDeviceSelectors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IList<string> DevicePickerFilter.SupportedDeviceSelectors is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IList%3Cstring%3E%20DevicePickerFilter.SupportedDeviceSelectors");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.DevicePickerFilter.SupportedDeviceClasses.get
		// Forced skipping of method Windows.Devices.Enumeration.DevicePickerFilter.SupportedDeviceSelectors.get
	}
}
