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
    }
}