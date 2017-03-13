using System;
using System.Collections.Generic;
using AulaSeis.DependencyServices;
using Xamarin.Forms;

namespace AulaSeis.View
{
    public partial class DependencyService : ContentPage
    {
        public DependencyService()
        {
            InitializeComponent();
            BindingContext = new ViewModel.DependencyServiceViewModel();
        }
    }
}
