using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormAndSettingEx
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<ContactList> _contactLists;

        public MainPage()
        {
            InitializeComponent();

            
            _contactLists =new ObservableCollection<ContactList>{
                new ContactList{Id=1,FirstName="Son",LastName="Chu Van"},
                new ContactList{Id=2,FirstName="Phuong",LastName="Ngo Thi"},
                new ContactList{Id=3,FirstName="Thinh",LastName="Nguyen Van"},
                new ContactList{Id=4,FirstName="Manh",LastName="Nguyen Xuan"},
            };
            listview.ItemsSource = _contactLists;
        }

        private async void ToolbarItem_Activated(object sender, EventArgs e)
        {
            var page = new ContactDetailPage(new ContactList());
            page.ContactAdd += (source, contact) =>
            {
                _contactLists.Add(contact);
            };
            await Navigation.PushAsync(page);
        }

        private async void listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listview.SelectedItem == null)
                return;
            var selectedContact = e.SelectedItem as ContactList;
            listview.SelectedItem = null;
            var page = new ContactDetailPage(selectedContact);
            page.ContactUpdate += (source, contact) =>
            {
                selectedContact.Id = contact.Id;
                selectedContact.FirstName = contact.FirstName;
                selectedContact.LastName = contact.LastName;
                selectedContact.Phone = contact.Phone;
                selectedContact.Email = contact.Email;
                selectedContact.IsBlocked = contact.IsBlocked;
            };
            await Navigation.PushAsync(page);
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactList;

            if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FirstName}?", "Yes", "No"))
                _contactLists.Remove(contact);
        }
    }
}
