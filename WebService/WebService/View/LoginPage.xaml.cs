using System;
using System.Collections.Generic;
using WebService.ViewModel;
using Xamarin.Forms;

namespace WebService.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
