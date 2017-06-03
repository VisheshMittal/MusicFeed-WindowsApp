using Callisto.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace App2
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Add the main call to the privacy policy
            SettingsPane.GetForCurrentView().CommandsRequested += DisplayPrivacyPolicy;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                if (!rootFrame.Navigate(typeof(MainPage), args.Arguments))
                {
                    throw new Exception("Failed to create initial page");
                }
            }
            // Ensure the current window is active
            Window.Current.Activate();

        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        //private void OnCommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        //{
        //    var privacy = new SettingsCommand("PrivacyPolicy", "PrivacyPolicy", (handler) =>
        //    {
        //        var settings = new SettingsFlyout();
        //        settings.Content = new PrivacyUserControl();
        //        //settings.HeaderBrush = new SolidColorBrush(_background);
        //        //settings.Background = new SolidColorBrush(_background);
        //        //settings.HeaderBrush = _Hbackground;
        //        //settings.Background = _background;
        //        settings.HeaderText = "Privacy Policy";
        //        settings.IsOpen = true;
        //    });

        //    args.Request.ApplicationCommands.Add(privacy);

        //    UICommandInvokedHandler handler1 = new UICommandInvokedHandler(onSettingsCommand);

        //    //  throw new NotImplementedException();
        //}

        //void onSettingsCommand(IUICommand command)
        //{
        //    SettingsCommand settingsCommand = (SettingsCommand)command;
        //    ((Frame)Window.Current.Content).Navigate(typeof(PrivacyUserControl));
        //}

        private void DisplayPrivacyPolicy(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        {
            SettingsCommand privacyPolicyCommand = new SettingsCommand("privacyPolicy", "Privacy Policy", (uiCommand) => { LaunchPrivacyPolicyUrl(); });
            args.Request.ApplicationCommands.Add(privacyPolicyCommand);
        }

        async void LaunchPrivacyPolicyUrl()
        {
            Uri privacyPolicyUrl = new Uri("https://skydrive.live.com/redir?resid=D5626C28AA2B6C7C!421&authkey=!AHB-z5Q48BLy43M&ithint=file%2c.txt", UriKind.Absolute);
            var result = await Windows.System.Launcher.LaunchUriAsync(privacyPolicyUrl);
        }

    }
}
