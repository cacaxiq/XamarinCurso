using WebService.Infra;
using WebService.View;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace WebService
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure("MainPage", typeof(MainPage));

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
