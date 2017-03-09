using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class MenuPage : ContentPage
    {
        public MenuPage()
        {
            Content = new StackLayout
            {
                Children = {
					new Label { Text = "I am the Menu page" }
				}
            };
        }
    }
}
