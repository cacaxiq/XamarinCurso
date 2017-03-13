using System;
using System.ComponentModel;
using AulaSeis.Custom;
using AulaSeis.iOS.Custom;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(BorderedEntryCustom))]
namespace AulaSeis.iOS.Custom
{
    public class BorderedEntryCustom : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderColor = UIColor.Red.CGColor;
            Control.Layer.BorderWidth = 1;
        }
    }
}
