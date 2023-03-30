#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.Workflow
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PrintWorkflowForegroundSetupRequestedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Printing.Workflow.PrintWorkflowConfiguration Configuration
		{
			get
			{
				throw new global::System.NotImplementedException("The member PrintWorkflowConfiguration PrintWorkflowForegroundSetupRequestedEventArgs.Configuration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PrintWorkflowConfiguration%20PrintWorkflowForegroundSetupRequestedEventArgs.Configuration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Graphics.Printing.PrintTicket.WorkflowPrintTicket> GetUserPrintTicketAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<WorkflowPrintTicket> PrintWorkflowForegroundSetupRequestedEventArgs.GetUserPrintTicketAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CWorkflowPrintTicket%3E%20PrintWorkflowForegroundSetupRequestedEventArgs.GetUserPrintTicketAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.Graphics.Printing.Workflow.PrintWorkflowForegroundSetupRequestedEventArgs.Configuration.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral PrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20PrintWorkflowForegroundSetupRequestedEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
