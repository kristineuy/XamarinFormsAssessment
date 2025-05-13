using System;
using XamarinFormsAssessment.Services;
using Xamarin.Forms;
using System.IO;

namespace XamarinFormsAssessment
{
    public partial class App : Application
    {
        static DBService database;

        public static DBService Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "entries.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}