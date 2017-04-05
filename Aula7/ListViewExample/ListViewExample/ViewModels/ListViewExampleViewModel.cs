using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Input;
using ListViewExample.Infra;
using ListViewExample.Model;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;

namespace ListViewExample.ViewModels
{
    public class ListViewExampleViewModel : EventChanged
    {
        public ListViewExampleViewModel()
        {



            ObservableCollection<FrutasGroup> Groups = GeradorFrutas.GerarListaFrutasGroup(20);


            FrutasGroup = Groups;



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

        public ObservableCollection<Fruta> Frutas
        {
            get;
            set;
        }

        public ObservableCollection<FrutasGroup> FrutasGroup
        {
            get;
            set;
        }

        public ICommand RefreshList
        {
            get { return new Command(AtualizaLista); }
        }


        public async void AtualizaLista()
        {
            IsRefreshing = true;
            await Task.Delay(5000);
            GeradorFrutas.GerarListaFrutas(Frutas);
            IsRefreshing = false;
        }
    }
}
