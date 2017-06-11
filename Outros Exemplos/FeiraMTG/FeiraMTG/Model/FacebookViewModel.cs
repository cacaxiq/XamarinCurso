using System.Threading.Tasks;
using PropertyChanged;
namespace FeiraMTG
{
    [ImplementPropertyChanged]
    public class FacebookViewModel
    {
        public FacebookViewModel()
        {
        }

        public FacebookProfile FacebookProfile
        {
            get;
            set;
        }

        public async Task SetFacebookUserProfileAsync(string accessToken)
        {
            var facebookServices = new FacebookServices();

            FacebookProfile = await facebookServices.GetFacebookProfileAsync(accessToken);
        }
    }
}
