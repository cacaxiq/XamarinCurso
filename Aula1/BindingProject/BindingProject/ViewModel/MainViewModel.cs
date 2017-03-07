using System;
using System.ComponentModel;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace BindingProject.ViewModel
{
    [ImplementPropertyChanged]
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigation navigation) : base(navigation)
        {
            Nome = "Carlos Henrique";

            Estado = "Amarrado!!!!";

            Navegar = new Command(async () => await Navigation.PushAsync(new SecondPage()));
        }

        public string Nome
        {
            get; set;
        }

        public string Estado
        {
            get; set;
        }

        public ICommand Navegar { get; set; }

    }
}

