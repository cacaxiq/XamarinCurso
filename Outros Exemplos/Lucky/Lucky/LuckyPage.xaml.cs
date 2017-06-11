using System;
using Xamarin.Forms;

namespace Lucky
{
    public partial class LuckyPage : ContentPage
    {
        public LuckyPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.LuckyViewModel();
        }

    }
}
