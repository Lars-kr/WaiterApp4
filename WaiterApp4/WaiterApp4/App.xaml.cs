﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaiterApp4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //MainPage = new NavigationPage(new OrderPage());
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
