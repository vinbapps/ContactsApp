// MainPage.xaml.cs
using ContactsApp;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ContactsApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Contact> Contacts { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "John Doe", PhoneNumber = "123-456-7890" },
                new Contact { Name = "Jane Doe", PhoneNumber = "987-654-3210" }
            };

            ContactsListView.BindingContext = this;
        }

        private void OnContactTapped(object sender, ItemTappedEventArgs e)
        {
            // Handle contact tapped (optional)
        }

        private async void OnAddContactClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddContactPage(Contacts));
        }
    }
}