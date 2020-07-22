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
    public partial class Halaman1 : ContentPage
    {
        //
        public Halaman1()
        {
            InitializeComponent();
        }

        private async void btnKeHal2_Clicked(object sender, EventArgs e)
        {
            var param = entryNama.Text;
            await Navigation.PushAsync(new Halaman2(param,"jl jambu 12"));
        }

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            Global.Instance.Name = entryNama.Text;
            Global.Instance.Address = "Jl Jambu 12";
            await DisplayAlert("Keterangan", "Global Variable berhasil dibuat", "OK");
        }

        private async void btnGetPreference_Clicked(object sender, EventArgs e)
        {
            string username="", password="";
            if (Preferences.ContainsKey("username"))
                username = Preferences.Get("username", "");
            if (Preferences.ContainsKey("password"))
                password = Preferences.Get("password", "");
            await DisplayAlert("Keterangan", $"Username:{username}, Password:{password}", "OK");

            //Preferences.Remove("username");
            //Preferences.Clear();
        }
    }
}