using Android.App;
using Android.Widget;
using Android.OS;

namespace SharedProject.Droid
{
    [Activity(Label = "SharedProject.Droid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            TextView text = FindViewById<TextView>(Resource.Id.textView1);

            text.Text = InfoDevice.GetVersionSO();
        }
    }
}

