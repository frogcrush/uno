#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Notifications
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ScheduledTileNotification 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Tag
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ScheduledTileNotification.Tag is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ScheduledTileNotification.Tag");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.ScheduledTileNotification", "string ScheduledTileNotification.Tag");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ScheduledTileNotification.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ScheduledTileNotification.Id");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.ScheduledTileNotification", "string ScheduledTileNotification.Id");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset? ExpirationTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset? ScheduledTileNotification.ExpirationTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%3F%20ScheduledTileNotification.ExpirationTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.ScheduledTileNotification", "DateTimeOffset? ScheduledTileNotification.ExpirationTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Data.Xml.Dom.XmlDocument Content
		{
			get
			{
				throw new global::System.NotImplementedException("The member XmlDocument ScheduledTileNotification.Content is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=XmlDocument%20ScheduledTileNotification.Content");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset DeliveryTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset ScheduledTileNotification.DeliveryTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20ScheduledTileNotification.DeliveryTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ScheduledTileNotification( global::Windows.Data.Xml.Dom.XmlDocument content,  global::System.DateTimeOffset deliveryTime) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Notifications.ScheduledTileNotification", "ScheduledTileNotification.ScheduledTileNotification(XmlDocument content, DateTimeOffset deliveryTime)");
		}
		#endif
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.ScheduledTileNotification(Windows.Data.Xml.Dom.XmlDocument, System.DateTimeOffset)
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.Content.get
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.DeliveryTime.get
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.ExpirationTime.set
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.ExpirationTime.get
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.Tag.set
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.Tag.get
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.Id.set
		// Forced skipping of method Windows.UI.Notifications.ScheduledTileNotification.Id.get
	}
}
