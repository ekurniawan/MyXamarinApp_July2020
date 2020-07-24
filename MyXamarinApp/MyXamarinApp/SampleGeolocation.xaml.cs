using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleGeolocation : ContentPage
    {
        public SampleGeolocation()
        {
            InitializeComponent();
        }

        private async void btnGeoLocation_Clicked(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);
                double latitude=location.Latitude, longitude=location.Longitude; 
                if (location != null)
                {
                    await DisplayAlert("Keterangan",
                        $"Lat: {location.Latitude} Long: {location.Longitude} Alt: {location.Altitude}", "OK");
                    var options = new MapLaunchOptions { Name = "Posisi Supir" };
                    await Map.OpenAsync(location, options);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Keterangan", ex.Message, "OK");
            }
           
        }
    }
}