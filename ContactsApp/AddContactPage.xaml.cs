// AddContactPage.xaml.cs
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ContactsApp
{
    public partial class AddContactPage : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        public AddContactPage(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();

            _contacts = contacts;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            _contacts.Add(new Contact
            {
                Name = NameEntry.Text,
                PhoneNumber = PhoneNumberEntry.Text
            });

            Navigation.PopAsync();
        }
    }
}
