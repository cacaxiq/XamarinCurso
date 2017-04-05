using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class ListAzure : ContentPage
    {
        public ListAzure()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListAzureViewModel();
        }
    }
}
