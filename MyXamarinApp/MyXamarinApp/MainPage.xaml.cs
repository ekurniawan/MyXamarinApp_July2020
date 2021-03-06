﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    //
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            var username = entryUsername.Text;
            var password = entryPassword.Text;
            var firstName = entryFirstName.Text;
            var lastName = entryLastName.Text;

            DisplayAlert("Keterangan", $"Welcome {firstName} {lastName}", "OK");
        }
    }
}
