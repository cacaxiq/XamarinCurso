using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeiraMTG
{
    public partial class WantCardsList : ContentPage
    {
        public WantCardsList()
        {
            var vm = new WantCardsListViewModel();
            BindingContext = vm;
            InitializeComponent();
            Listviewteste.ItemsSource =  vm.CardList;
        }

        public async void OnDelete(object sender, EventArgs e)
        {
            var mi = (Card)((MenuItem)sender).CommandParameter;
            var answer = await DisplayAlert("Confirmar", "A carta " + mi.Nome + "deve ser realmente removida?", "Remover", "Cancelar");

            if (answer)
            {
                await DisplayAlert("Removido com sucesso", "", "OK");
            }
        }
    }
}
