using Nokia.Music.Types;
using Nokia.Music;
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
using System.Net.NetworkInformation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Tweets : App2.Common.LayoutAwarePage
    {
        public Tweets()
        {
            this.InitializeComponent();

            itemGridView.ItemsSource = getId();
            itemListView.ItemsSource = getId();            
        }

        private static List<Artist> getId()
        {
            Artist adele = new Artist();
            adele.Id = "372350";
            adele.Name = "Adele";
            adele.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/372350.jpg");
            adele.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/372350.jpg");

            Artist akon = new Artist();
            akon.Id = "349570";
            akon.Name = "Akon";
            akon.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/349570.jpg");
            akon.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/349570.jpg");

            Artist beyonce = new Artist();
            beyonce.Id = "300987";
            beyonce.Name = "Beyonce";
            beyonce.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/300987.jpg");
            beyonce.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/300987.jpg");

            Artist britney = new Artist();
            britney.Id = "287807";
            britney.Name = "Britney Spears";
            britney.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/287807.jpg");
            britney.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/287807.jpg");

            Artist bruno = new Artist();
            bruno.Id = "626716";
            bruno.Name = "Bruno Mars";
            bruno.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/626716.jpg");
            bruno.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/626716.jpg");

            Artist eminem = new Artist();
            eminem.Id = "1519";
            eminem.Name = "Eminem";
            eminem.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1519.jpg");
            eminem.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1519.jpg");

            Artist florida = new Artist();
            florida.Id = "406925";
            florida.Name = "Flo Rida";
            florida.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/406925.jpg");
            florida.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/406925.jpg");

            Artist justin = new Artist();
            justin.Id = "1213944";
            justin.Name = "Justin Bieber";
            justin.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1213944.jpg");
            justin.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1213944.jpg");

            Artist kanye = new Artist();
            kanye.Id = "349095";
            kanye.Name = "Kanye West";
            kanye.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/349095.jpg");
            kanye.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/349095.jpg");

            Artist katy = new Artist();
            katy.Id = "667115";
            katy.Name = "Katy Perry";
            katy.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/667115.jpg");
            katy.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/667115.jpg");

            Artist kesha = new Artist();
            kesha.Id = "1102183";
            kesha.Name = "Kesha";
            kesha.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1102183.jpg");
            kesha.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1102183.jpg");

            Artist lady = new Artist();
            lady.Id = "697517";
            lady.Name = "Lady Gaga";
            lady.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/697517.jpg");
            lady.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/697517.jpg");

            Artist linkin = new Artist();
            linkin.Id = "287738";
            linkin.Name = "Linkin Park";
            linkin.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/287738.jpg");
            linkin.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/287738.jpg");

            Artist lorde = new Artist();
            lorde.Id = "42246501";
            lorde.Name = "Lorde";
            lorde.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/42246501.jpg");
            lorde.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/42246501.jpg");

            Artist miley = new Artist();
            miley.Id = "662388";
            miley.Name = "Miley Cyrus";
            miley.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/662388.jpg");
            miley.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/662388.jpg");

            Artist oneRepublic = new Artist();
            oneRepublic.Id = "329086";
            oneRepublic.Name = "One Republic";
            oneRepublic.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/329086.jpg");
            oneRepublic.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/329086.jpg");

            Artist rihanna = new Artist();
            rihanna.Id = "305681";
            rihanna.Name = "Rihanna";
            rihanna.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/305681.jpg");
            rihanna.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/305681.jpg");

            Artist taylor = new Artist();
            taylor.Id = "824505";
            taylor.Name = "Taylor Swift";
            taylor.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/824505.jpg");
            taylor.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/824505.jpg");

            Artist rolling = new Artist();
            rolling.Id = "1448";
            rolling.Name = "The Rolling Stones";
            rolling.Thumb320Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1448.jpg");
            rolling.Thumb100Uri = new Uri("http://asset.ent.nokia.com/asset/artists/320x320/1448.jpg");

            List<Artist> Names = new List<Artist>
            {
                adele, akon, beyonce, britney, bruno, eminem, florida, justin, kanye, katy, kesha, lady, linkin, lorde, miley,
                oneRepublic, rihanna, taylor, rolling
            };

            return Names;
        }


        //private List<Artist> _Names = new List<Artist>
        //{
        //    //"Adele",
        //    //"Akon",
        //    //"Beyonce",
        //    //"Britney Spears",
        //    //"Bruno Mars",
        //    //"Eminem",
        //    //"Flo Rida",
        //    //"Justin Bieber",
        //    //"Kanye-West",
        //    //"Katy Perry",
        //    //"Kesha",
        //    //"Lady Gaga",
        //    //"Linkin Park",          
        //    //"Lorde",
        //    //"Metallica",           
        //    //"Miley Cyrus",
        //    //"One Direction",
        //    //"One Republic",
        //    //"Rihanna",
        //    //"TaylorSwift",
        //    //"The Rolling Stones"
        //};

        private void artistsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                progressBar1.IsIndeterminate = true;
                progressBar1.Visibility = Windows.UI.Xaml.Visibility.Visible;

                if (itemListView.Visibility == Windows.UI.Xaml.Visibility.Collapsed)
                {
                    var selectedArtist = (Artist)itemGridView.SelectedItem;
                    string selectedArtistName = selectedArtist.Name;
                    progressBar1.IsIndeterminate = false;
                    progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    Frame.Navigate(typeof(_TweetsPage), selectedArtistName);
                }
                else if (itemListView.Visibility == Windows.UI.Xaml.Visibility.Visible)
                {
                    var selectedArtist = (Artist)itemListView.SelectedItem;
                    string selectedArtistName = selectedArtist.Name;
                    progressBar1.IsIndeterminate = false;
                    progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                    Frame.Navigate(typeof(_TweetsPage), selectedArtistName);
                }
            }
            else
            {
                MessageBox.Show("Please check your Internet Connection or try again later.");
                progressBar1.IsIndeterminate = false;
                progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
