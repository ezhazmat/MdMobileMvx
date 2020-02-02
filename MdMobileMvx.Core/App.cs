using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace MdMobileMvx.Core
{
    public class App : MvxApplication
    {
        public static string AzureBackendUrl =
            DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static bool UseMockDataStore = true;
        public override void Initialize()
        {
            base.Initialize();
            RegisterCustomAppStart<AppStart>();
        }
    }
}
