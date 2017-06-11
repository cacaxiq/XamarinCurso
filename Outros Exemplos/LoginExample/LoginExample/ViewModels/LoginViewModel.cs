using System;
using System.Windows.Input;

namespace LoginExample.ViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
        }


        private string _login;
        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public ICommand ForgotPasswordCommand
        {
            get
            {
                return new Xamarin.Forms.Command(() =>
                {
                    throw new NotImplementedException();
                }

                );
            }
        }
    }
}
