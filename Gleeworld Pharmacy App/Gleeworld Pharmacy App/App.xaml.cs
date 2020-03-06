﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Gleeworld_Pharmacy_App.Services;
using Gleeworld_Pharmacy_App.Views;

namespace Gleeworld_Pharmacy_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
