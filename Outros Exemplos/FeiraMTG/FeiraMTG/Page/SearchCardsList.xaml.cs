using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeiraMTG
{
    public partial class SearchCardsList : ContentPage
    {
        public SearchCardsList()
        {
            var vm = new SearchCardsListViewModel();
            BindingContext = vm;
            InitializeComponent();
            Listviewteste.ItemsSource = vm.CardList;
        }

        public async void SendMessage(object sender, EventArgs e)
        {
            var mi = (Card)((MenuItem)sender).CommandParameter;
            var answer = await DisplayAlert("Enviar mensagem", "A carta " + mi.Nome + " é do meu interesse!! Podemos iniciar uma negociaçao?", "Enviar", "Cancelar");

            if (answer)
            {
                await DisplayAlert("Enviado com sucesso", "", "OK");
            }
        }
    }
}
