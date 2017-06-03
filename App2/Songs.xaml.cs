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
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace App2
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Songs : App2.Common.LayoutAwarePage
    {
        public Songs()
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

            MusicClient ApiClient = new MusicClient("59930f5c5f71d0321ae70fada9e64c67");
            this.ResponseHandler<Product>(await ApiClient.GetNewReleasesAsync(Category.Track, startIndex: 0, itemsPerPage: 20));

            progressBar1.IsIndeterminate = false;
            progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void ResponseHandler<T>(ListResponse<T> response)
        {
            ////this.Loading.Visibility = Visibility.Collapsed;
            this.itemGridView.ItemsSource = response.Result;
            this.itemListView.ItemsSource = response.Result;

            if (response.Result != null)
            {
                if (response.Result.Count == 0)
                {
                    ////this.TotalResults.Visibility = Visibility.Collapsed;
                    MessageBox.Show(@"No results found");
                    progressBar1.IsIndeterminate = false;
                    progressBar1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
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
