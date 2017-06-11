using System;
using Xamarin.Forms;

namespace LoginExample.Helpers.CustomRenders
{
    public class BorderedEntry : Entry
    {
        public static readonly BindableProperty TypeBorderProperty =
            BindableProperty.Create("TypeBorder", typeof(int), typeof(BorderedEntry), 1);

        public int TypeBorder
        {
            get { return (int)GetValue(TypeBorderProperty); }
            set { SetValue(TypeBorderProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create("BorderColor", typeof(Color), typeof(BorderedEntry), default(Color));

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create("BorderWidth", typeof(float), typeof(BorderedEntry), default(float));

        public float BorderWidth
        {
            get { return (float)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }
    }
}