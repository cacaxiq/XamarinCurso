using System;
using System.Collections.Generic;
using BindingProject.ViewModel;

using Xamarin.Forms;

namespace BindingProject
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
