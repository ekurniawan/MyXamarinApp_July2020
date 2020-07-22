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
    public partial class SampleListBinding : ContentPage
    {
        public SampleListBinding()
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

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectData = (ListItem)e.Item;
            await DisplayAlert("Keterangan",
                $"Title: {selectData.Title}, Desc: {selectData.Description}","OK");
        }
    }
}