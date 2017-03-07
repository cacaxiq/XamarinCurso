using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterPage
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
                Title = "Detalhe 01",
                IconSource = "icon.png",
                TargetType = new DetailsPage01()
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Detalhe 02",
                IconSource = "icon.png",
                TargetType = new DetailsPage02()
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Detalhe 03",
                IconSource = "icon.png",
                TargetType = new DetailsPage03()
            });

            listView.ItemsSource = masterPageItems;
        }
    }
}
