﻿using System;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Private.Infrastructure;
using Uno.UI.RuntimeTests.Helpers;
using Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml.Controls;

#if !WINDOWS_UWP && !WINAPPSDK
using Uno.UI.Xaml;
using Uno.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;
using Windows.UI;
using Colors = Microsoft.UI.Colors;
#endif

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_Xaml;

[TestClass]
public class Given_Window
{
	[TestCleanup]
	public void CleanupTest()
	{
		TestServices.WindowHelper.CloseAllSecondaryWindows();
	}

#if !HAS_UNO_WINUI && !WINAPPSDK
	[TestMethod]
	[RunsOnUIThread]
	public void When_Primary_Window_UWP()
	{
		// The current window on UWP should be a CoreWindow.
		var mainVisualTreeXamlRoot = WinUICoreServices.Instance.MainVisualTree?.XamlRoot;
		Assert.AreEqual(Window.Current.Content.XamlRoot, mainVisualTreeXamlRoot);
	}
#endif

#if HAS_UNO_WINUI || WINAPPSDK

	private bool SupportsMultipleWindows() =>
#if HAS_UNO
		NativeWindowFactory.SupportsMultipleWindows;
#else
		true;
#endif

#if HAS_UNO
	[TestMethod]
	[RunsOnUIThread]
	public void When_CreateNewWindow_Unsupported()
	{
		if (!CoreApplication.IsFullFledgedApp)
		{
			Assert.Inconclusive("This test can only be run in a full-fledged app");
			return;
		}

		if (SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment without multiwindow support");
		}

		var act = () => new Window(WindowType.DesktopXamlSource);
		act.Should().Throw<InvalidOperationException>();
	}

	[TestMethod]
	[RunsOnUIThread]
	public void When_Create_Multiple_Windows()
	{
		if (!CoreApplication.IsFullFledgedApp)
		{
			Assert.Inconclusive("This test can only be run in a full-fledged app");
			return;
		}

		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var startingNumberOfWindows = ApplicationHelper.Windows.Count;

		for (int i = 0; i < 10; i++)
		{
			var sut = new Window(WindowType.DesktopXamlSource);
			sut.Close();
		}

		var endNumberOfWindows = ApplicationHelper.Windows.Count;
		Assert.AreEqual(startingNumberOfWindows, endNumberOfWindows);
	}

	[TestMethod]
	[RunsOnUIThread]
	public void When_Close_Non_Activated_Window()
	{
		if (!CoreApplication.IsFullFledgedApp)
		{
			Assert.Inconclusive("This test can only be run in a full-fledged app");
			return;
		}

		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window(WindowType.DesktopXamlSource);
		bool closedFired = false;
		sut.Closed += (s, e) => closedFired = true;
		sut.Close();

		Assert.IsTrue(closedFired);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_No_Background_Light_Dark()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		using var _ = ThemeHelper.UseDarkTheme();
		var sut = new NoBackgroundWindow();

		await VerifyWindowBackgroundAsync(sut, false, Colors.Black);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_No_Background_Light()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new NoBackgroundWindow();

		await VerifyWindowBackgroundAsync(sut, false, Colors.White);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_No_Background_Switch_Theme()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new NoBackgroundWindow();

		await VerifyWindowBackgroundAsync(sut, false, Colors.White);

		using var _ = ThemeHelper.UseDarkTheme();
		await VerifyWindowBackgroundAsync(sut, true, Colors.Black);
	}

	private static async Task VerifyWindowBackgroundAsync(Window sut, bool wasActivated, Color expectedColor)
	{
		if (!wasActivated)
		{
			bool activated = false;
			sut.Activated += (s, e) => activated = true;
			sut.Activate();

			await TestServices.WindowHelper.WaitFor(() => activated);
		}

		await TestServices.WindowHelper.WaitForLoaded(sut.Content as FrameworkElement);

		// Verify that center of window is red
		var rootElement = sut.Content.XamlRoot.VisualTree.RootElement;
		Assert.IsInstanceOfType(rootElement, typeof(Panel));
		var rootElementAsPanel = (Panel)rootElement;
		var rootElementBackground = rootElementAsPanel.Background;
		Assert.IsInstanceOfType(rootElementBackground, typeof(SolidColorBrush));
		var rootElementBackgroundAsSolidColorBrush = (SolidColorBrush)rootElementBackground;
		Assert.AreEqual(expectedColor, rootElementBackgroundAsSolidColorBrush.Color);
	}
#endif

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_Opens()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		bool activated = false;
		sut.Content = new Border();
		sut.Activated += (s, e) => activated = true;
		sut.Activate();
		await TestServices.WindowHelper.WaitFor(() => activated);
		Assert.IsTrue(activated);
		await TestServices.WindowHelper.WaitForLoaded(sut.Content as FrameworkElement);
		Assert.IsTrue(sut.Bounds.Width > 0);
		Assert.IsTrue(sut.Bounds.Height > 0);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_Content_Loads()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		bool loaded = false;
		var border = new Border();
		var button = new Button();
		button.Content = "Hello!";
		border.Child = button;
		sut.Content = border;
		button.Loaded += (s, e) => loaded = true;
		sut.Activate();
		await TestServices.WindowHelper.WaitFor(() => loaded);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_Content_Non_Zero_Size()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		var button = new Button();
		button.Content = "Hello!";
		sut.Content = button;
		sut.Activate();
		await TestServices.WindowHelper.WaitFor(() => button.ActualWidth > 0);
		Assert.IsTrue(button.ActualWidth > 0);
		Assert.IsTrue(button.ActualHeight > 0);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Secondary_Window_From_Xaml()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new RedWindow();
		sut.Activate();
		await TestServices.WindowHelper.WaitForLoaded(sut.Content as FrameworkElement);

		// Verify that center of window is red
		var initialScreenshot = await UITestHelper.ScreenShot(sut.Content as FrameworkElement);

		var color = initialScreenshot.GetPixel(initialScreenshot.Width / 2, initialScreenshot.Height / 2);
		color.Should().Be(Colors.Red);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Close_Programmatically_Does_Not_Trigger_AppWindow_Closing()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		var content = new Border() { Width = 100, Height = 100 };
		sut.Content = content;
		bool closingTriggered = false;
		sut.AppWindow.Closing += (s, e) => closingTriggered = true;

		sut.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);

		sut.Close();

		closingTriggered.Should().BeFalse();
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Close_Programmatically_Triggers_Window_Closed()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		var content = new Border() { Width = 100, Height = 100 };
		sut.Content = content;
		bool closedTriggered = false;

		sut.Closed += (s, e) => closedTriggered = true;

		sut.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);

		sut.Close();

		closedTriggered.Should().BeTrue();
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Closed_Is_Handled()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		bool contentUnloaded = false;
		var sut = new Window();
		var content = new Border() { Width = 100, Height = 100 };
		content.Unloaded += (s, e) => contentUnloaded = true;
		sut.Content = content;
		bool closedTriggered = false;

		bool shouldHandle = true;
		sut.Closed += (s, e) =>
		{
			e.Handled = shouldHandle;
			closedTriggered = true;
		};

		sut.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);

		sut.Close();

		closedTriggered.Should().BeTrue();

		// The window should still be open
		Assert.IsTrue(sut.Visible);

		closedTriggered = false;
		shouldHandle = false;

		sut.Close();
		closedTriggered.Should().BeTrue();

		// The window should now be closed
		Assert.IsFalse(sut.Visible);

		await TestServices.WindowHelper.WaitFor(() => contentUnloaded);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Close_Programmatically_Event_Order()
	{
		if (!SupportsMultipleWindows())
		{
			Assert.Inconclusive("This test can only run in an environment with multiwindow support");
		}

		var sut = new Window();
		var content = new Border() { Width = 100, Height = 100 };
		sut.Content = content;
		string eventOrder = "";
		content.Unloaded += (s, e) => eventOrder += "(Unloaded)";
		sut.Closed += (s, e) => eventOrder += "(Window.Closed)";
		sut.AppWindow.Closing += (s, e) => eventOrder += "(AppWindow.Closing)";

		sut.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);

		sut.Close();

		await TestServices.WindowHelper.WaitFor(() => eventOrder.Contains("(Window.Closed)"));
		await TestServices.WindowHelper.WaitFor(() => eventOrder.Contains("(Unloaded)"));

		eventOrder.Should().BeEquivalentTo("(Window.Closed)(Unloaded)");
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Closed_Handler_In_Xaml()
	{
		var window = new WindowClosed();
		var content = new Border() { Width = 100, Height = 100 };
		window.Content = content;
		window.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);
		window.Close();

		await TestServices.WindowHelper.WaitFor(() => window.ClosedExecuted);
	}

	[TestMethod]
	[RunsOnUIThread]
	public async Task When_Window_Title_In_Xaml()
	{
		var window = new WindowClosed();
		var content = new Border() { Width = 100, Height = 100 };
		window.Content = content;
		window.Activate();

		await TestServices.WindowHelper.WaitForLoaded(content);
		Assert.AreEqual("Test title", window.Title);
	}
#endif
}
