using PortableProject.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(InfoDevice))]
namespace PortableProject.Droid
{
    public class InfoDevice : IInfoDevice
    {
        public InfoDevice()
        {
        }

        public string GetVersionSO()
        {
            string api = Android.OS.Build.VERSION.Sdk;

            string versaoAndroid = Android.OS.Build.VERSION.SdkInt.ToString();

            string release = Android.OS.Build.VERSION.Release;

            return string.Format("Android {0} com a versão {1} executando a api {2}.", versaoAndroid, release, api);
        }
    }
}
