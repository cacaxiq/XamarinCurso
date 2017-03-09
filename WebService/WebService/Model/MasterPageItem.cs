using System;
using Xamarin.Forms;

namespace WebService.Model
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