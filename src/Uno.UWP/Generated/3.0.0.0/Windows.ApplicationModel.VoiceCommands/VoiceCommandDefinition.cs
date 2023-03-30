#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.VoiceCommands
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VoiceCommandDefinition 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Language
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VoiceCommandDefinition.Language is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VoiceCommandDefinition.Language");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VoiceCommandDefinition.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VoiceCommandDefinition.Name");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition.Language.get
		// Forced skipping of method Windows.ApplicationModel.VoiceCommands.VoiceCommandDefinition.Name.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction SetPhraseListAsync( string phraseListName,  global::System.Collections.Generic.IEnumerable<string> phraseList)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction VoiceCommandDefinition.SetPhraseListAsync(string phraseListName, IEnumerable<string> phraseList) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20VoiceCommandDefinition.SetPhraseListAsync%28string%20phraseListName%2C%20IEnumerable%3Cstring%3E%20phraseList%29");
		}
		#endif
	}
}
