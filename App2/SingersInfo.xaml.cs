using Nokia.Music;
using Nokia.Music.Types;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Net;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SingersInfo : App2.Common.LayoutAwarePage
    {
        public SingersInfo()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected async override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            progressBar1.IsIndeterminate = true;
            progressBar1.Visibility = Windows.UI.Xaml.Visibility.Visible;

            parameterSingersInfo collectedPar = navigationParameter as parameterSingersInfo;
            if (collectedPar.thumb != null)
            {
                Uri artistThumb = collectedPar.thumb;
                this.ArtistThumb.Source = new BitmapImage(new Uri(WebUtility.UrlDecode(artistThumb.AbsoluteUri)));
            }
            else
            {
                this.ArtistThumb.Source = new BitmapImage(new Uri("ms-appx:///Assets/music200.png", UriKind.Absolute));
            }

            String pageTitle = collectedPar.name;
            PageTitle.Text = pageTitle;
            ArtistName.Text = pageTitle;

            if (collectedPar.country != null)
            {           
                ArtistOrigin.Text = collectedPar.country;
            }

            
            Artist artist = new Artist();
            artist.Id = collectedPar.id;
            MusicClient ApiClient = new MusicClient("59930f5c5f71d0321ae70fada9e64c67");
            this.ResponseHandler<Artist>(await ApiClient.GetSimilarArtistsAsync(artist, 0, 20));
            this.ResponseHandler2<Product>(await ApiClient.GetArtistProductsAsync(artist, startIndex: 0, itemsPerPage: 20));

            progressBar1.IsIndeterminate = false;
            progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void ResponseHandler2<T1>(ListResponse<Product> listResponse)
        {
            ////this.Loading.Visibility = Visibility.Collapsed;
            this.itemGridView.ItemsSource = listResponse.Result;

            if (listResponse.Result != null)
            {
                if (listResponse.Result.Count == 0)
                {
                    ////this.TotalResults.Visibility = Visibility.Collapsed;
                     MessageBox.Show(@"No results found");
                }
                else
                {
                    if (listResponse.TotalResults != null)
                    {
                        ////this.TotalResults.Text = string.Format("{0:#,###0} item(s) available", response.TotalResults.Value);
                        ////this.TotalResults.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ////this.TotalResults.Visibility = Visibility.Collapsed;
                    }
                }
            }
            else if (listResponse.Error != null)
            {
                MessageBox.Show("Please check your Internet Connection or try again later.");
            }
        }


        private void ResponseHandler<T>(ListResponse<T> response)
        {
            ////this.Loading.Visibility = Visibility.Collapsed;
            this.itemListView.ItemsSource = response.Result;

            if (response.Result != null)
            {
                if (response.Result.Count == 0)
                {
                    ////this.TotalResults.Visibility = Visibility.Collapsed;
                     MessageBox.Show(@"No results found");
                }
                else
                {
                    if (response.TotalResults != null)
                    {
                        ////this.TotalResults.Text = string.Format("{0:#,###0} item(s) available", response.TotalResults.Value);
                        ////this.TotalResults.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ////this.TotalResults.Visibility = Visibility.Collapsed;
                    }
                }
            }
            else if (response.Error != null)
            {
                MessageBox.Show("Please check your Internet Connection or try again later.");
            }
        }


        private void ItemClick(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selected_artist = itemListView.SelectedItem as Artist;
                if (selected_artist.Id != null &&
                   selected_artist.Name != null &&
                   selected_artist.Thumb320Uri != null &&
                   selected_artist.Origin != null)
                {
                    parameterSingersInfo parAll = new parameterSingersInfo(selected_artist.Id,
                                                                         selected_artist.Name,
                                                                         selected_artist.Thumb320Uri,
                                                                         selected_artist.Origin.Name);
                    Frame.Navigate(typeof(SingersInfo), parAll);

                }

                else if (selected_artist.Thumb320Uri == null &&
                    selected_artist.Id != null &&
                   selected_artist.Name != null &&
                   selected_artist.Origin != null)
                {

                    {
                        parameterSingersInfo parExThumb = new parameterSingersInfo(selected_artist.Id,
                                                                            selected_artist.Name,
                                                                            selected_artist.Origin.Name);
                        Frame.Navigate(typeof(SingersInfo), parExThumb);
                    }
                }

                else if (selected_artist.Origin == null &&
                    selected_artist.Id != null &&
                   selected_artist.Name != null &&
                   selected_artist.Thumb320Uri != null)
                {

                    {
                        parameterSingersInfo parExCountry = new parameterSingersInfo(selected_artist.Id,
                                                                         selected_artist.Name,
                                                                         selected_artist.Thumb320Uri);
                        Frame.Navigate(typeof(SingersInfo), parExCountry);
                    }
                }

                else if (selected_artist.Thumb320Uri == null &&
                        selected_artist.Origin == null &&
                        selected_artist.Id != null &&
                        selected_artist.Name != null)
                {

                    {
                        parameterSingersInfo parExThumbCountry = new parameterSingersInfo(selected_artist.Id,
                                                                            selected_artist.Name);
                        Frame.Navigate(typeof(SingersInfo), parExThumbCountry);
                    }
                }

                else
                {
                    MessageBox.Show("Unable to complete request");
                }

            }

            catch (Exception)
            {
                //MessageBox.Show(nav_ex.ToString());
            }
        }


        private void artistTopSongs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Product selectedProduct = itemListView.SelectedItem as Product;
            
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Singers));
        }
    }
}
