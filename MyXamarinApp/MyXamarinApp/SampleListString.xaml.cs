using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListString : ContentPage
    {
        public SampleListString()
        {
            InitializeComponent();

            List<string> lstKota = new List<string>
            {
                "Jakarta","Bandung","Yogyakarta","Surabaya","Palembang"
            };
            lvKota.ItemsSource = lstKota;
        }

        private async void lvKota_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedCity = (string)e.Item;
            await DisplayAlert("Keterangan", $"Data yg dipilih: {selectedCity}", "OK");
        }
    }
}