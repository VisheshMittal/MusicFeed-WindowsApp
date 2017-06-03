using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : App2.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();

            itemListView.ItemsSource = getList();
        }

        ///// <summary>
        ///// Populates the page with content passed during navigation.  Any saved state is also
        ///// provided when recreating a page from a prior session.
        ///// </summary>
        ///// <param name="navigationParameter">The parameter value passed to
        ///// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        ///// </param>
        ///// <param name="pageState">A dictionary of state preserved by this page during an earlier
        ///// session.  This will be null the first time a page is visited.</param>
        //protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        //{
        //    SettingsPane.GetForCurrentView().CommandsRequested += GroupedItemsPage_CommandsRequested;
        //}

        private void showArtists_Click(object sender, RoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                Frame.Navigate(typeof(Singers));
            }
            else
            {
                MessageBox.Show("Please check your Internet Connection");
            }
        }

        private void newReleases_Click(object sender, TappedRoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                Frame.Navigate(typeof(Songs));
            }
            else
            {
                MessageBox.Show("Please check your Internet Connection");
            }
        }

        private void tweets_Click(object sender, TappedRoutedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                Frame.Navigate(typeof(Tweets));
            }
            else
            {
                MessageBox.Show("Please check your Internet Connection");
            }
        }

        private static List<mainPageItemList> getList()
        {
            //Artist adele = new Artist();
            //adele.Id = "372350";
            //adele.Name = "Adele";
            //adele.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/372350.jpg");
            //adele.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/372350.jpg");

            mainPageItemList item1 = new mainPageItemList();
            item1.TileImage = new Uri("ms-appx:///Images/Text Edit.png");
            item1.TileName = "New Releases";

            mainPageItemList item2 = new mainPageItemList();
            item2.TileImage = new Uri("ms-appx:///Images/Twitter-Bird.png");
            item2.TileName = "Tweets";

            mainPageItemList item3 = new mainPageItemList();
            item3.TileImage = new Uri("ms-appx:///Images/Electric-Guitar-02.png");
            item3.TileName = "Artists";

            List<mainPageItemList> _mainPageList = new List<mainPageItemList>
            {
                item1, item2, item3
            };

            return _mainPageList;
        }

        private void mainPageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTile = (mainPageItemList)itemListView.SelectedItem;
            string selectedTileName = selectedTile.TileName;

            switch (selectedTileName)
            {
                case "New Releases":
                    Frame.Navigate(typeof(Songs));
                    break;
                case "Tweets":
                    Frame.Navigate(typeof(Tweets));
                    break;
                case "Artists":
                    Frame.Navigate(typeof(Singers));
                    break;
                default: break;
            }
        }

        private void GoBackMain(object sender, RoutedEventArgs e)
        {
        }

        //public static void AddSettingsCommands(SettingsPaneCommandsRequestedEventArgs args)
        //{
        //    args.Request.ApplicationCommands.Clear();
 
        //    SettingsCommand privacyPref = new SettingsCommand("privacyPref", "Privacy Policy", (uiCommand) =>
        //    {
        //        Windows.System.Launcher.LaunchUriAsync(new Uri("http://www.myserver.com/myPrivacyPolicy.aspx"));
        //    });
 
        //        args.Request.ApplicationCommands.Add(privacyPref);
        //}


        //void GroupedItemsPage_CommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
        //{
        //       SettingsHelper.AddSettingsCommands(args);
        //}


    }
}

//Link to the app in the store
//https://www.microsoft.com/en-us/store/apps/music-feed/9wzdncrdhs3x
