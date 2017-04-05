using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.MainViewModel(this.Navigation);
        }
    }
}
