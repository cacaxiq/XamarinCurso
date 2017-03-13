using System;
using System.Collections.Generic;
using AulaSeis.ViewModel;
using Xamarin.Forms;

namespace AulaSeis.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(this.Navigation);
        }
    }
}
