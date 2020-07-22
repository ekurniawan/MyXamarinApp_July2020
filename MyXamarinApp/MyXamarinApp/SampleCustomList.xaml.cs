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
    public partial class SampleCustomList : ContentPage
    {
        public SampleCustomList()
        {
            InitializeComponent();

            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Android",
                Description = "Xamarin with Traditional Android UI",
                ImageSource = "monkey1.png",
                Price = 100000
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin IOS",
                Description = "Xamarin with Traditional IOS UI",
                ImageSource = "monkey2.png",
                Price = 200000
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Xamarin with Cross Platform UI",
                ImageSource = "monkey3.png",
                Price = 300000
            });
            lvData.ItemsSource = lstItems;
        }
    }
}