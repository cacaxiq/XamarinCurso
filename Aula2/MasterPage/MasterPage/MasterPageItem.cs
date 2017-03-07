using System;
using Xamarin.Forms;

namespace MasterPage
{
    public class MasterPageItem
    {
        public string Title
        {
            get;
            set;
        }
        public string IconSource
        {
            get;
            set;
        }
        public ContentPage TargetType { get; set; }
    }
}