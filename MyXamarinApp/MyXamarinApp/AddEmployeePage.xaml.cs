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
    public partial class AddEmployeePage : ContentPage
    {
        private EmployeeServices _empServices;
        public AddEmployeePage()
        {
            InitializeComponent();
            _empServices = new EmployeeServices();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmployeeName = entryName.Text,
                Designation = entryDesignation.Text,
                Qualification = entryQualification.Text,
                Department = entryDepartment.Text
            };

            try
            {
                
                await _empServices.Insert(newEmp);
                await DisplayAlert("Keterangan",
                    $"Data Employee {newEmp.EmployeeName} berhasil ditambahkan", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }
    }
}