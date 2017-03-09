using System;
using System.Windows.Input;
using WebService.Infra;
using WebService.Infra.Validadores;
using WebService.Model;
using Xamarin.Forms;
using WebService.Service;
using System.Threading.Tasks;

namespace WebService.ViewModel
{
    public class LoginViewModel : ObservedClass
    {

        public LoginViewModel()
        {
            Login = new Login();

            Logar = new Command(() => ExecutarLogin(Login));
        }

        public Login Login
        {
            get;
            set;
        }


        public bool Ocupado
        {
            get;
            set;
        }

        public string MensagemLogin
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

        public async void ExecutarLogin(Login login)
        {
            Ocupado = true;
            OnPropertyChangedByName("Ocupado");

            var LoginService = new LoginService();
            var ocupado = await LoginService.Logar(login);
            if (ocupado)
            {
                MensagemLogin = "Login bem sucedido!";
                OnPropertyChangedByName("MensagemLogin");
                await Task.Delay(5000);
                App.NavigationService.NavigateTo("MainPage", null, HistoryBehavior.ClearHistory);
            }
            else
            {
                MensagemLogin = "Problemas no acesso.";
                OnPropertyChangedByName("MensagemLogin");
            }

            Ocupado = false;
            OnPropertyChangedByName("Ocupado");
            OnPropertyChangedByName("Ocupado");
        }
    }
}
