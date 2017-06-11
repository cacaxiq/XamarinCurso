using Xamarin.Forms;

namespace LoginExample.Helpers.Behaviors
{
    public class LengthBehavior : Behavior<Entry>
    {
        public static readonly BindableProperty LengthProperty =
            BindableProperty.Create("Length", typeof(int), typeof(LengthBehavior), 1);

        public int Length
        {
            get { return (int)GetValue(LengthProperty); }
            private set { base.SetValue(LengthProperty, value); }
        }

        public static readonly BindableProperty TypeProperty =
            BindableProperty.Create("Type", typeof(string), typeof(LengthBehavior), string.Empty);

        public string Type
        {
            get { return (string)base.GetValue(TypeProperty); }
            private set { base.SetValue(TypeProperty, value); }
        }

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var control = ((Entry)sender);

            if (Type.ToLower() == "max" && args.NewTextValue.Length > Length)
            {
                control.Text = args.OldTextValue;
            }

            if (Type.ToLower() == "min")
            {
                var isValid = args.NewTextValue.Length < Length;
                control.TextColor = isValid ? Color.Red : Color.Default;
            }
        }
    }
}
