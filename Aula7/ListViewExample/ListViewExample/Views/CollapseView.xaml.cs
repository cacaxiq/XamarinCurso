using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Views
{
    public partial class CollapseView : ContentPage
    {
        public CollapseView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.ListViewExampleViewModel();
        }
    }
}
