using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataAccess
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                title.Text = Application.Current.Properties["Name"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("NotificationEnabled"))
            {
                notificationEnable.On = (bool) Application.Current.Properties["NotificationEnabled"];
            }
        }

        private void OnChange(object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationEnabled"] = notificationEnable.On;

            
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
