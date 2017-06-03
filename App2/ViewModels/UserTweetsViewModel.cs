using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    public class UserTweetsViewModel
    {
        public string Label { get; set; }

        public ObservableCollection<TweetModel> Tweets { get; set; }

        private const string consumerKey = "AHLhavLvDvqjmJ2MZUwKrw";
        private const string consumerSecret = "t5Ll9oSNGMgJUrQmwS3gxyfPe6Z1jueSOkaw90a0aE";
        private const string twitterAccessToken = "1552348146-vGJFZ0umPXiWX9w6xrbZSY1ihhtG3BoCAUTIYSF";
        private const string twitterAccessTokenSecret = "a6iEXGe7DD0F2EznqxiEmASA4MnSKWG0QMmGgflc2a1Cm";

        public UserTweetsViewModel()
        { }

        public UserTweetsViewModel(string userName, int count)
        {
            this.Label = string.Format("Tweets by @{0}", userName);
            this.Tweets = GetTwitterUserTimeLine(userName, count);
        }

        private ObservableCollection<TweetModel> GetTwitterUserTimeLine(string userName, int count)
        {

            ObservableCollection<TweetModel> result = new ObservableCollection<TweetModel>();

            var auth = new SingleUserAuthorizer
            {
                Credentials = new SingleUserInMemoryCredentials
                {
                    ConsumerKey = consumerKey,
                    ConsumerSecret = consumerSecret,
                    TwitterAccessToken = twitterAccessToken,
                    TwitterAccessTokenSecret = twitterAccessTokenSecret
                }
            };

            auth.Authorize();

            TwitterContext twitterCtx = new TwitterContext(auth);
            var tweets = twitterCtx.Status.Where(tweet => tweet.ScreenName == userName && tweet.Type == StatusType.User).Take(count).ToList();
            foreach (var item in tweets)
            {
                TweetModel tweet = new TweetModel()
                {
                    Text = item.Text,
                    ScreenName = item.User.Name,
                    UserName = "@" + item.ScreenName,
                    PublicationDate = GetElapsedPeriod(item.CreatedAt),
                    Image = item.User.ProfileImageUrl

                };
                result.Add(tweet);
            }
            return result;
        }

        /// <summary>
        /// Get elapsed period from a date.
        /// </summary>
        /// <param name="d">Date</param>
        /// <returns>Well formated elapsed period</returns>
        /// <seealso cref="http://www.dotnetperls.com/pretty-date"/>
        private string GetElapsedPeriod(DateTime d)
        {
            // 1.
            // Get time span elapsed since the date.
            TimeSpan s = DateTime.Now.Subtract(d);

            // 2.
            // Get total number of days elapsed.
            int dayDiff = (int)s.TotalDays;

            // 3.
            // Get total number of seconds elapsed.
            int secDiff = (int)s.TotalSeconds;

            // 5.
            // Handle same-day times.
            if (dayDiff == 0)
            {
                // A.
                // Less than one minute ago.
                if (secDiff < 60)
                {
                    return "just now";
                }
                // B.
                // Less than 2 minutes ago.
                if (secDiff < 120)
                {
                    return "1 minute ago";
                }
                // C.
                // Less than one hour ago.
                if (secDiff < 3600)
                {
                    return string.Format("{0} minutes ago",
                        Math.Floor((double)secDiff / 60));
                }
                // D.
                // Less than 2 hours ago.
                if (secDiff < 7200)
                {
                    return "1 hour ago";
                }
                // E.
                // Less than one day ago.
                if (secDiff < 86400)
                {
                    return string.Format("{0} hours ago",
                        Math.Floor((double)secDiff / 3600));
                }
            }
            // 6.
            // Handle previous days.
            if (dayDiff == 1)
            {
                return "yesterday";
            }
            if (dayDiff < 7)
            {
                return string.Format("{0} days ago",
                dayDiff);
            }
            if (dayDiff < 31)
            {
                return string.Format("{0} weeks ago",
                Math.Ceiling((double)dayDiff / 7));
            }


            return d.ToString();
        }
    }
}
