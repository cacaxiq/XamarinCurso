using Xamarin.Forms;

namespace NotificationExample
{
    public partial class NotificationExamplePage : ContentPage
    {
        public NotificationExamplePage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<ICustomNotification>().CallNotification();

        }
    }
}
