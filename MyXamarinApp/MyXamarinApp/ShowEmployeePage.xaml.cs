using MyXamarinApp.Models;
using MyXamarinApp.Services;
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
    public partial class ShowEmployeePage : ContentPage
    {
        private EmployeeServices _empServices;
        public ShowEmployeePage()
        {
            InitializeComponent();
            _empServices = new EmployeeServices();
        }

        private async Task LoadData()
        {
            lvEmployee.ItemsSource = await _empServices.GetAll();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await LoadData();
        }

        private async void menuAddEmp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeePage());
        }

        private async void lvEmployee_Refreshing(object sender, EventArgs e)
        {
            await LoadData();
            lvEmployee.IsRefreshing = false;
        }

        private async void lvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (Employee)e.Item;
            EditEmployeePage editEmpPage = new EditEmployeePage();
            editEmpPage.BindingContext = item;
            await Navigation.PushAsync(editEmpPage);
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var menuItem = (MenuItem)sender;
            var empId = Convert.ToInt32(menuItem.CommandParameter); 
            var konfirmasi = await DisplayAlert("Konfirmasi", 
                $"Apakah anda yakin delete data id: {empId}", "Yes","No");
            if (konfirmasi)
            {
                try
                {
                    await _empServices.Delete(empId);
                    await DisplayAlert("Keterangan", $"Data dengan id {empId} berhasil didelete", "OK");
                    await LoadData();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Kesalahan", ex.Message, "OK");
                }
            }
        }
    }
}