using System;
using Xamarin.Forms;

namespace FeiraMTG
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginWithFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FacebookProfilePage());
        }
    }
}
