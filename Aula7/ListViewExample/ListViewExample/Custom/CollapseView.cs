using System;
using Xamarin.Forms;

namespace ListViewExample.Custom
{
    public class CollapseView : ListView
    {
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(nameof(Titulo), typeof(string), typeof(CollapseView), string.Empty, BindingMode.TwoWay);


        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }

        public CollapseView()
        {
            HeaderTemplate = new DataTemplate(() =>
            {
                return new ViewCell() { View = new StackLayoutCollapse(this) };
            });
        }
    }

    public class StackLayoutCollapse : StackLayout
    {
        public StackLayoutCollapse(CollapseView lista)
        {
            Orientation = StackOrientation.Horizontal;

            this.Children.Add(new Label { Text = lista.Titulo, TextColor = Color.FromHex("005569"), FontSize = 15, VerticalOptions = LayoutOptions.Center });
            this.Children.Add(new ButtonCollapse(lista) { Text = "Teste", FontFamily = "FontAwesome", VerticalOptions = LayoutOptions.End });
        }
    }
}
