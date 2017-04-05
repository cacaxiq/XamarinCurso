using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class ListViewRefresh : ContentPage
    {
        public ListViewRefresh()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExampleViewModel();
        }
    }
}
