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
    public partial class Halaman2 : ContentPage
    {
        public Halaman2()
        {
            InitializeComponent();
        }

        public Halaman2(string nama)
        {
            InitializeComponent();
            lblNama.Text = $"Nama anda : {nama}";
        }

        public Halaman2(string name, string address)
        {
            InitializeComponent();
            lblNama.Text = $"Nama : {name} and Address: {address}";
        }
    }
}