using System;
using LoginExample.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonCustom))]
namespace LoginExample.Droid.Custom
{
    public class ButtonCustom : ButtonRenderer
    {
        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);
        }
    }
}
