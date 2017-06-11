using System;
using Xamarin.Forms;

namespace LoginExample.Helpers.Behaviors
{
    public class BaseBehavior : Behavior<View>
    {
        protected override void OnAttachedTo(View view)
        {
            view. += Handle_Clicked;
            base.OnAttachedTo(View);
        }

        protected override void OnDetachingFrom(View button)
        {
            View.Clicked -= Handle_Clicked;
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
