using System;
using System.Collections.Generic;
using WebService.Infra;
using Xamarin.Forms;

namespace WebService.View
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var args = this.GetNavigationArgs();
            // passedArguments.Text = $"Passed arguments: {args}";

            base.OnAppearing();
        }
    }
}
