using System;
using Xamarin.Forms;

namespace BindingProject.ViewModel
{
    public class BaseViewModel
    {
        public INavigation Navigation;


        public BaseViewModel(INavigation _navigation)
        {
            Navigation = _navigation;
        }
    }
}
