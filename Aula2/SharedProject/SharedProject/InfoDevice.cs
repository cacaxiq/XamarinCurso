using System;
namespace SharedProject
{
    public class InfoDevice
    {


        public static string GetVersionSO()
        {
#if __IOS__
            // iOS specific code
            Version version = new Version(ObjCRuntime.Constants.Version);
            return string.Format("Iphone executando a versão {0} so seu sistema operacional.", version);
#elif __ANDROID__
            // Android specific code
            string api = Android.OS.Build.VERSION.Sdk;

            string versaoAndroid = Android.OS.Build.VERSION.SdkInt.ToString();

            string release = Android.OS.Build.VERSION.Release;

            return string.Format("Android {0} com a versão {1} executando a api {2}.", versaoAndroid, release, api);
#elif WINDOWS_UWP
 // Universal Windows Platform specific code

#elif WINDOWS_APP
 // Windows 8.1 specific code

#elif WINDOWS__PHONE_APP
 // Windows Phone 8.1 specific code

#endif
        }
    }
}
