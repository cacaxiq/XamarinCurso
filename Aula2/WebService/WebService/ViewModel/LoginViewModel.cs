using System;
using System.Windows.Input;
using WebService.Infra;
using WebService.Infra.Validadores;
using WebService.Model;
using Xamarin.Forms;

namespace WebService.ViewModel
{
    public class LoginViewModel : ObservedClass
    {

        public LoginViewModel()
        {
            Login = new Login();

            HabilitarLogin = "false";

            Logar = new Command(() => ComandLogar());
        }

        public Login Login
        {
            get;
            set;
        }

        public string HabilitarLogin
        {
            get;
            set;
        }

        private ICommand _logar;
        public ICommand Logar
        {
            get { return _logar; }
            set { _logar = value; OnPropertyChanged(); }
        }

        public void ComandLogar()
        {
            App.NavigationService.NavigateTo("SecondPage",);
        }
    }
}
