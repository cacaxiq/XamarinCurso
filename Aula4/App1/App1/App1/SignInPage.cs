using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class SignInPage : ContentPage
    {
        private SignInViewModel _viewModel;

        private Entry _userName;
        private Entry _password;
        private Button _button;

        public SignInPage(SignInViewModel vm)
        {
            BindingContext = _viewModel = vm;

            _userName = new Entry
            {
                Placeholder = "Username"
            };

            _password = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };

            _button = new Button
            {
                Text = "Sign In"
            };
            _button.Clicked += Button_Clicked;

            Content = new StackLayout
            {
                Children =
                {
                    _userName,
                    _password,
                    _button,
				}
            };
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            _viewModel.SignIn();
        }
    }
}
