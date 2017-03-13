using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AulaSeis.Custom
{
    public class ImageArrow : Image
    {
        public static BindableProperty CommandProperty = BindableProperty.Create<ImageArrow, ICommand>(bp => bp.Command, default(ICommand));

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public ImageArrow()
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
}
