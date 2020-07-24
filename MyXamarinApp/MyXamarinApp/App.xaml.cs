using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

            InitializeComponent();

            //Device.SetFlags(new string[] { "RadioButton_Experimental" });
            MainPage = new NavigationPage(new SampleGeolocation());

            //MainPage = new MyPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
