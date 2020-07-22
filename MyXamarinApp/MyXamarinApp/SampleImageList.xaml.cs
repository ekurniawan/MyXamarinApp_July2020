using MyXamarinApp.Models;
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
    public partial class SampleImageList : ContentPage
    {
        public SampleImageList()
        {
            InitializeComponent();

            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Android",
                Description = "Xamarin with Traditional Android UI",
                ImageSource = "monkey1.png"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin IOS",
                Description = "Xamarin with Traditional IOS UI",
                ImageSource = "monkey2.png"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Xamarin with Cross Platform UI",
                ImageSource = "monkey3.png"
            });
            lvData.ItemsSource = lstItems;
        }

        private async void btnCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleCustomList());
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            var nama = Global.Instance.Name;
            var address = Global.Instance.Address;
            lblNama.Text = nama;
            await DisplayAlert("Keterangan", $"Nama: {nama}, Address:{address}", "OK");
        }
    }
}