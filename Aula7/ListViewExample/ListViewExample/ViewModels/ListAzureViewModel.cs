using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Input;
using ListViewExample.Infra;
using ListViewExample.Model;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;


namespace ListViewExample.ViewModels
{
    public class ListAzureViewModel : EventChanged
    {
        public ListAzureViewModel()
        {

            var MobileService = new AzureService();
            var lista = MobileService.ObterFrutas();
            Frutas = new ObservableCollection<FrutasAzure>(lista.Result);
        }

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<FrutasAzure> Frutas
        {
            get;
            set;
        }

        public ICommand RefreshList
        {
            get { return new Command(AtualizaLista); }
        }


        public void AtualizaLista()
        {
            IsRefreshing = true;
            GeradorFrutasAzure.GerarListaFrutas(30);
            IsRefreshing = false;
        }
    }
}
