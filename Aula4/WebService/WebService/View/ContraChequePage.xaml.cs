using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WebService.View
{
    public partial class ContraChequePage : ContentPage
    {
        public ContraChequePage()
        {
            InitializeComponent();
        }

        public async void ShowModal(object sender, EventArgs e)
        {
            //var mi = (Card)((MenuItem)sender).CommandParameter;
            var answer = await DisplayAlert("Enviar mensagem", "Olá eu sou uma modal!! O que vc achou?", "Gostei!", "Não gostei.");

            if (answer)
            {
                await DisplayAlert("Obrigado pelo feedback", "", "OK");
            }
        }
    }
}
