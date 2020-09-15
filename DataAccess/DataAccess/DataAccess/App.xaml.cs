using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataAccess
{
    public partial class App : Application
    {
        private const string TitleKey = "Name";
        private const string NotificationEnabledKey = "NotificationEnabled";
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();
                return "";
            }
            set
            {
                Properties[TitleKey] = value;
            }
        }
        public bool NotificationEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationEnabledKey))
                    return (bool) Properties[NotificationEnabledKey];
                return false;
            }
            set
            {
                Properties[NotificationEnabledKey] = value;
            }
        }
    }
}
