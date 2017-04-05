using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewExample.Custom
{
    public class ButtonArrow : Image
    {
        public static BindableProperty CommandProperty = BindableProperty.Create<ButtonArrow, ICommand>(bp => bp.Command, default(ICommand));

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public ButtonArrow()
        {
            var gesto = new TapGestureRecognizer();
            gesto.Tapped += (sender, e) =>
            {
                var image = (Image)sender;


                if (image.Rotation == 0)
                {
                    image.Rotation = 270;
                }
                else { image.Rotation = 0; }



                if (this.Command != null && this.Command.CanExecute(null))
                {
                    this.Command.Execute(null);
                }
            };

            this.GestureRecognizers.Add(gesto);
        }
    }

    public class ButtonCollapse : Button
    {


        public ButtonCollapse(ListView lista)
        {
            this.Clicked += (sender, e) =>
                {
                    if (this.Rotation == 0)
                    {
                        this.Rotation = 270;
                        lista.IsVisible = true;
                    }
                    else
                    {
                        this.Rotation = 0;
                        lista.IsVisible = false;
                    }


                };
        }

    }
}
