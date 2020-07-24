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
    public partial class SampleSyncfusion : ContentPage
    {
        private EmployeeServices _empService;
        public SampleSyncfusion()
        {
            InitializeComponent();

            _empService = new EmployeeServices();
        }

        protected async override void OnAppearing()
        {
            var data = await _empService.GetAll();
            var lstNamaEmp = (from n in data
                             select n.EmployeeName).ToList();
            myCombobox.ComboBoxSource = lstNamaEmp;
        }
    }
}