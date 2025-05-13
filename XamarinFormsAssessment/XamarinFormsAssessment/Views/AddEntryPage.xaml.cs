using Xamarin.Forms;
using System;
using Entry = XamarinFormsAssessment.Models.Entry;
using Xamarin.CommunityToolkit.Extensions;

namespace XamarinFormsAssessment
{
    public partial class AddEntryPage : ContentPage
    {
        public AddEntryPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var newEntry = new Entry
            {
                FirstName = firstNameField.Text,
                LastName = lastNameField.Text,
                DateOfBirth = dateOfBirthField.Date
            };

            await App.Database.SaveEntryAsync(newEntry);
            await this.DisplayToastAsync("Entry added.");
            await Navigation.PopAsync();
        }
    }
}