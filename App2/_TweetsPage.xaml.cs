using App2.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class _TweetsPage : Page
    {
        public UserTweetsViewModel UserTweetsWidget { get; set; }

        public _TweetsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string tweetArtistName = e.Parameter as string;
            string tweetArtist_screenName = "";

            switch (tweetArtistName)
            {
                case "Katy Perry": tweetArtist_screenName = "katyperry"; break;
                case "Eminem": tweetArtist_screenName = "Eminem"; break;
                case "Rihanna": tweetArtist_screenName = "rihanna"; break;
                case "Adele": tweetArtist_screenName = "OfficialAdele"; break;
                case "Lorde": tweetArtist_screenName = "lordemusic"; break;
                case "Bruno Mars": tweetArtist_screenName = "BrunoMars"; break;
                case "Lady Gaga": tweetArtist_screenName = "ladygaga"; break;
                case "One Republic": tweetArtist_screenName = "OneRepublic"; break;
                case "Miley Cyrus": tweetArtist_screenName = "MileyCyrus"; break;
                case "One Direction": tweetArtist_screenName = "onedirection"; break;
                case "Taylor Swift": tweetArtist_screenName = "taylorswift13"; break;
                case "Justin Bieber": tweetArtist_screenName = "justinbieber"; break;
                case "Kesha": tweetArtist_screenName = "keshasuxx"; break;
                case "Flo Rida": tweetArtist_screenName = "official_flo"; break;
                case "Akon": tweetArtist_screenName = "Akon"; break;
                case "Britney Spears": tweetArtist_screenName = "britneyspears"; break;
                case "Linkin Park": tweetArtist_screenName = "linkinpark"; break;
                case "Metallica": tweetArtist_screenName = "Metallica"; break;
                case "Beyonce": tweetArtist_screenName = "Beyonce"; break;
                case "Kanye-West": tweetArtist_screenName = "kanyewest"; break;
                case "The Rolling Stones": tweetArtist_screenName = "RollingStones"; break;
                default: break;
            }

            UserTweetsWidget = new UserTweetsViewModel(tweetArtist_screenName, 20);
            this.DataContext = this;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tweets));
        }
    }
}
