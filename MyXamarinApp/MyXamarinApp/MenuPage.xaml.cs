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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnImageList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleImageList());
        }

        private async void menuCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleCustomList());
        }

        private async void menuBindingList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleListBinding());
        }

        private async void menuAdd_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", "Add Data", "OK");
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var output = await DisplayActionSheet("Share ke media?", "Cancel", null,
                "Facebook", "Twitter", "IG", "Whatsapp");
            await DisplayAlert("Keterangan", $"Anda memilih: {output}", "OK");
        }

        private async void btnDisplay_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Konfirmasi", "Delete data?", "Yes", "No");
            if (result)
                await DisplayAlert("Keterangan", "Anda menjawab Yes", "OK");
            else
                await DisplayAlert("Keterangan", "Anda menjawab No", "OK");
        }
    }
}