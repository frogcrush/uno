#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Chat
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class ChatMessageBlocking 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction MarkMessageAsBlockedAsync( string localChatMessageId,  bool blocked)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ChatMessageBlocking.MarkMessageAsBlockedAsync(string localChatMessageId, bool blocked) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ChatMessageBlocking.MarkMessageAsBlockedAsync%28string%20localChatMessageId%2C%20bool%20blocked%29");
		}
		#endif
	}
}
