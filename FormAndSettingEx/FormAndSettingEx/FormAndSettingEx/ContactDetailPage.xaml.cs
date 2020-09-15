using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormAndSettingEx;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormAndSettingEx
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public event EventHandler<ContactList> ContactAdd;
        public event EventHandler<ContactList> ContactUpdate;
        public ContactDetailPage(ContactList contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }
            InitializeComponent();

            BindingContext = new ContactList
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Phone = contact.Phone,
                Email = contact.Email,
                IsBlocked = contact.IsBlocked
            };

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var contact = BindingContext as ContactList;
            if (String.IsNullOrWhiteSpace(contact.FirstName) && String.IsNullOrWhiteSpace(contact.LastName))
            {
                await DisplayAlert("Error", "Please enter the name", "ok");
                return;
            }
            if (contact.Id == 0)
            {
                contact.Id = 1;
                ContactAdd?.Invoke(this, contact);
            }
            else
            {
                ContactUpdate?.Invoke(this, contact);
            }
            await Navigation.PopAsync();
        }
    }
}