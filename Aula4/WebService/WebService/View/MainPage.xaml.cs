using System;
using System.Collections.Generic;
using WebService.Model;
using Xamarin.Forms;

namespace WebService.View
{
    public partial class MainPage : MasterDetailPage
    {
        public string Texto;

        public MainPage()
        {
            InitializeComponent();
            masterPage.ListView.ItemSelected += OnItemSelected;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage(item.TargetType);
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }



    }
}
