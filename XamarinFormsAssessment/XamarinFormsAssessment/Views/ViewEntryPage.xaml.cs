using Xamarin.Forms;
using System;
using Entry = XamarinFormsAssessment.Models.Entry;
using Xamarin.CommunityToolkit.Extensions;

namespace XamarinFormsAssessment
{
    public partial class ViewEntryPage : ContentPage
    {
        private Entry currentEntry;

        public ViewEntryPage(Entry entry)
        {
            InitializeComponent();
            currentEntry = entry;
            BindingContext = currentEntry;
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            await App.Database.DeleteEntryAsync(currentEntry);
            await this.DisplayToastAsync("Entry deleted.");
            await Navigation.PopAsync();
        }
    }
}