using System;
using Xamarin.Forms;

namespace WebService.Infra.Validadores
{
    public class StringValidatorBehavior
    {
        public static readonly BindableProperty AttachBehaviorProperty =
             BindableProperty.CreateAttached("AttachBehavior", typeof(bool), typeof(StringValidatorBehavior), false, propertyChanged: OnAttachBehaviorChanged);

        public static bool GetAttachBehavior(BindableObject view)
        {
            return (bool)view.GetValue(AttachBehaviorProperty);
        }

        public static void SetAttachBehavior(BindableObject view, bool value)
        {
            view.SetValue(AttachBehaviorProperty, value);
        }

        static void OnAttachBehaviorChanged(BindableObject view, object oldValue, object newValue)
        {
            var entry = view as Entry;
            if (entry == null)
            {
                return;
            }

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {

            bool isValid = args.NewTextValue.Length >= 6 && args.NewTextValue.Length <= 10;
            ((Entry)sender).TextColor = isValid ? Color.Green : Color.Red;
        }
    }
}
