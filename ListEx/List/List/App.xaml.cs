﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace List
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListEx();
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
