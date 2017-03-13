using System;
using Xamarin.Forms;

namespace AulaSeis.Custom
{
    public class BorderedEntry : Entry
    {
        public static readonly BindableProperty TipoBordaProperty = BindableProperty.Create<BorderedEntry, int>(p => p.TipoBorda, default(int));
        public static readonly BindableProperty CorBordaProperty = BindableProperty.Create<BorderedEntry, Color>(p => p.CorBorda, default(Color));
        public static readonly BindableProperty TamanhoBordaProperty = BindableProperty.Create<BorderedEntry, float>(p => p.TamanhoBorda, default(float));


        public BorderedEntry()
        {

        }

        public int TipoBorda
        {
            get { return (int)GetValue(TipoBordaProperty); }
            set { SetValue(TipoBordaProperty, value); }
        }

        public Color CorBorda
        {
            get { return (Color)GetValue(CorBordaProperty); }
            set { SetValue(CorBordaProperty, value); }
        }

        public float TamanhoBorda
        {
            get { return (float)GetValue(TamanhoBordaProperty); }
            set { SetValue(TamanhoBordaProperty, value); }
        }
    }
}
