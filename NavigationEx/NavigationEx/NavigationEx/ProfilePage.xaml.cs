﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage(FriendList friend)
        {
            if (friend == null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = friend;
            InitializeComponent();
        }
    }
}