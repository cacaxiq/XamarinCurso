using Android.App;
using Android.Content;
using NotificationExample.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.Dependency(typeof(CustomNotification))]
namespace NotificationExample.Droid
{
    public class CustomNotification : PageRenderer, ICustomNotification
    {

        public void CallNotification()
        {
            Context Context = this.Context;

            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Context)
                .SetContentTitle("Sample Notification")
                .SetContentText("Hello World! This is my first notification!")
                .SetSmallIcon(Resource.Drawable.ic_stat_button_click);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager = Context.GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }
    }
}
