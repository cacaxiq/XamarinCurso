using System;
using System.Windows.Input;
using Xamarin.Forms;
using AulaSeis.View;

namespace AulaSeis.ViewModel
{
    public class MainViewModel
    {
        INavigation Navegacao;

        public MainViewModel(INavigation _navegacao)
        {
            Navegacao = _navegacao;
        }

        public ICommand DependencyService
        {
            get { return new Command(() => ChangePage(new View.DependencyService())); }
        }

        public ICommand CustomRender
        {
            get { return new Command(() => ChangePage(new View.CustomRender())); }
        }

        public ICommand CustomControl
        {
            get { return new Command(() => ChangePage(new View.CustomControl())); }
        }

        public ICommand ExampleRelativeLayout
        {
            get { return new Command(() => ChangePage(new View.RelativeLayoutExample())); }
        }

        private async void ChangePage(Page page)
        {
            await Navegacao.PushAsync(page);
        }
    }
}
