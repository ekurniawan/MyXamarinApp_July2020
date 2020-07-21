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
    public partial class SampleGridLayout : ContentPage
    {
        public SampleGridLayout()
        {
            InitializeComponent();

            btnTambah.Clicked += BtnProses_Clicked;

            List<string> listKota = new List<string>();
            listKota.Add("Jakarta");
            listKota.Add("Surabaya");
            listKota.Add("Yogyakarta");
            pickerCity.ItemsSource = listKota;
        }

        private void BtnProses_Clicked(object sender, EventArgs e)
        {
            var bil1 = Convert.ToDouble(entryBil1.Text);
            var bil2 = Convert.ToDouble(entryBil2.Text);
            double hasil = 0;
            var btn = (Button)sender;

            switch (btn.Text)
            {
                case "Tambah":
                    hasil = bil1 + bil2;
                    break;
                case "Kurang":
                    hasil = bil1 - bil2;
                    break;
                case "Kali":
                    hasil = bil1 * bil2;
                    break;
                case "Bagi":
                    hasil = bil1 / bil2;
                    break;
            }
            entryHasil.Text = hasil.ToString();
        }

      
    }
}