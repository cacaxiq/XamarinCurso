using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            Master = new MenuPage
            {
                Title = "Sign In Demo App"
            };
            Detail = new NavigationPage(new MainPage());
        }
    }
}
