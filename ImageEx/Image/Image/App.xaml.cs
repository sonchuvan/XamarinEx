﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Image
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageEx();
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
