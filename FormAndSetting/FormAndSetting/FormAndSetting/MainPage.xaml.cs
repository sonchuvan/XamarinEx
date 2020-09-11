using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormAndSetting
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            timepicker.Time = DateTime.Now.TimeOfDay;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var address = picker.Items[picker.SelectedIndex];
            DisplayAlert("Selection", address, "OK");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var Page = new AddressList();
            Page.address.ItemSelected += (source, args) =>
             {
                 ListAddress.Text = args.SelectedItem.ToString();
                 Navigation.PopAsync();
             };
            Navigation.PushAsync(Page);
        }
    }
}
