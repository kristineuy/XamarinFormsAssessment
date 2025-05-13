using Xamarin.Forms;
using System.Linq;
using System;
using Entry = XamarinFormsAssessment.Models.Entry;

namespace XamarinFormsAssessment
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            entriesView.ItemsSource = await App.Database.GetAllEntriesAsync();
        }

        async void OnAddEntryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEntryPage());
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Entry entry = (Entry)e.CurrentSelection.FirstOrDefault();
                await Navigation.PushAsync(new ViewEntryPage(entry));
            }
        }
    }
}