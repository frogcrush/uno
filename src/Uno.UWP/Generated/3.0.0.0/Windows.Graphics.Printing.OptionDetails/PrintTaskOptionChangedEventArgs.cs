#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.OptionDetails
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintTaskOptionChangedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  object OptionId
		{
			get
			{
				throw new global::System.NotImplementedException("The member object PrintTaskOptionChangedEventArgs.OptionId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=object%20PrintTaskOptionChangedEventArgs.OptionId");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs.OptionId.get
	}
}
