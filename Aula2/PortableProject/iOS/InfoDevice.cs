using System;
using PortableProject.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(InfoDevice))]
namespace PortableProject.iOS
{
    public class InfoDevice : IInfoDevice
    {
        public InfoDevice()
        {
        }

        public string GetVersionSO()
        {
            Version version = new Version(ObjCRuntime.Constants.Version);
            return string.Format("Iphone executando a versão {0} so seu sistema operacional.", version);
        }
    }
}
