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

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            lvEmployee.ItemsSource = await _empServices.GetAll();
        }

        private async void menuAddEmp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeePage());
        }
    }
}