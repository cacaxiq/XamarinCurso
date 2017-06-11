using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace LoginExample.Helpers.Behaviors
{
    public class ButtonBehavior : Behavior<Button>
    {
        protected override void OnAttachedTo(Button button)
        {
            button.Clicked += Handle_Clicked;
            base.OnAttachedTo(button);
        }

        protected override void OnDetachingFrom(Button button)
        {
            button.Clicked -= Handle_Clicked;
            base.OnDetachingFrom(button);
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var control = ((Button)sender);

            control.TextColor = Color.Orange;
            await Task.Delay(200);
            control.TextColor = Color.Default;
        }
    }
}

