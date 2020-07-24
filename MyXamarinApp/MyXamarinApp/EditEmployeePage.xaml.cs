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
    public partial class EditEmployeePage : ContentPage
    {
        private EmployeeServices _empServices;
        public EditEmployeePage()
        {
            InitializeComponent();
            _empServices = new EmployeeServices();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmployeeId = Convert.ToInt32(entryID.Text),
                EmployeeName = entryName.Text,
                Designation = entryDesignation.Text,
                Qualification = entryQualification.Text,
                Department = entryDepartment.Text
            };
            try
            {
                await _empServices.Edit(editEmp);
                await DisplayAlert("Keterangan", $"Edit Data Employee Id: {editEmp.EmployeeId} berhasil", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Keterangan", ex.Message, "OK");
            }
        }
    }
}