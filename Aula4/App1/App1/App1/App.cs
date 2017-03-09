using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class App : Application
    {
        public App()
        {
            var vm = new SignInViewModel();
            vm.PropertyChanged += SignInViewModel_PropertyChanged;

            // The root page of your application
            MainPage = new SignInPage(vm);
        }

        void SignInViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var vm = sender as SignInViewModel;
            switch(e.PropertyName)
            {
                case "SignInRequired":
                {
                    if(vm.SignInRequired)
                    {
                        if (!(MainPage is SignInPage))
                        {
                            MainPage = new SignInPage(vm);
                        }
                    }
                    else
                    {
                        MainPage = new MyMasterDetailPage();
                    }
                    break;
                }
            }
        }
    }
}
