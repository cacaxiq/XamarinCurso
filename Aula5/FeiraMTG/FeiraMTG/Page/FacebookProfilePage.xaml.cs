using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeiraMTG
{
public partial class FacebookProfilePage : ContentPage
    {

        /// <summary>
        /// Make sure to get a new ClientId from:
        /// https://developers.facebook.com/apps/
        /// </summary>
        private string ClientId = "620085424684934";

        public FacebookProfilePage()
        {
            InitializeComponent();

            var apiRequest =
                "https://www.facebook.com/dialog/oauth?client_id=" 
                + ClientId
                + "&display=popup&response_type=token&redirect_uri=https://www.facebook.com/connect/login_success.html";

            var webView = new WebView
            {
                Source = apiRequest,
                HeightRequest = 1
            };

            webView.Navigated += WebViewOnNavigated;

            Content = webView;
        }

        private async void WebViewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            
            var accessToken = ExtractAccessTokenFromUrl(e.Url);

            if (accessToken != "")
            {
                //var vm = new FacebookViewModel();

                //BindingContext = vm;

                //await vm.SetFacebookUserProfileAsync(accessToken);

                //Content = MainStackLayout;

                await Navigation.PushAsync(new MainPage());
            }
        }

        private string ExtractAccessTokenFromUrl(string url)
        {
            if (url.Contains("access_token") && url.Contains("&expires_in="))
            {
                var at = url.Replace("https://www.facebook.com/connect/login_success.html#access_token=", "");

                var accessToken = at.Remove(at.IndexOf("&expires_in="));

                return accessToken;
            }

            return string.Empty;
        }
    }

}
