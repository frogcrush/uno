#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.PointOfService
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CashDrawerStatus 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ExtendedStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint CashDrawerStatus.ExtendedStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20CashDrawerStatus.ExtendedStatus");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.PointOfService.CashDrawerStatusKind StatusKind
		{
			get
			{
				throw new global::System.NotImplementedException("The member CashDrawerStatusKind CashDrawerStatus.StatusKind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CashDrawerStatusKind%20CashDrawerStatus.StatusKind");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.PointOfService.CashDrawerStatus.StatusKind.get
		// Forced skipping of method Windows.Devices.PointOfService.CashDrawerStatus.ExtendedStatus.get
	}
}
