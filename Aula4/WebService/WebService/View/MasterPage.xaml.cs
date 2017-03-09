using System;
using System.Collections.Generic;
using WebService.Model;
using Xamarin.Forms;

namespace WebService.View
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dados Cadastrais",
                IconSource = "icon.png",
                TargetType = new DadosCadastraisPage()
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Extrato Contribuições",
                IconSource = "icon.png",
                TargetType = new ExtratoContribuicaoPage()
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "ContraCheque",
                IconSource = "icon.png",
                TargetType = new ContraChequePage()
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
