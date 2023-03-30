#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class KnownContactField 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string Email
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownContactField.Email is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownContactField.Email");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string InstantMessage
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownContactField.InstantMessage is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownContactField.InstantMessage");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownContactField.Location is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownContactField.Location");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string PhoneNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member string KnownContactField.PhoneNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownContactField.PhoneNumber");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Contacts.KnownContactField.Email.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.KnownContactField.PhoneNumber.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.KnownContactField.Location.get
		// Forced skipping of method Windows.ApplicationModel.Contacts.KnownContactField.InstantMessage.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Contacts.ContactFieldType ConvertNameToType( string name)
		{
			throw new global::System.NotImplementedException("The member ContactFieldType KnownContactField.ConvertNameToType(string name) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ContactFieldType%20KnownContactField.ConvertNameToType%28string%20name%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string ConvertTypeToName( global::Windows.ApplicationModel.Contacts.ContactFieldType type)
		{
			throw new global::System.NotImplementedException("The member string KnownContactField.ConvertTypeToName(ContactFieldType type) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20KnownContactField.ConvertTypeToName%28ContactFieldType%20type%29");
		}
		#endif
	}
}
