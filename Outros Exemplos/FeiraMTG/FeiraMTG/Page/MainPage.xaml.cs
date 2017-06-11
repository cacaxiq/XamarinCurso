using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeiraMTG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();
            InitializeComponent();
        }

        private async void AddCards_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCards());
        }

        private async void ChangedCardsList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChangedCardsList());
        }

        private async void SearchCardsList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchCardsList());
        }

        private async void WantCardsList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WantCardsList());
        }
    }
}
