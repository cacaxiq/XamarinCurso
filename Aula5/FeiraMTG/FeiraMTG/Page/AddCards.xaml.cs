using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FeiraMTG
{
    public partial class AddCards : ContentPage
    {
        public AddCards()
        {
            BindingContext = new AddCardsViewModel();
            InitializeComponent();
        }
    }
}
