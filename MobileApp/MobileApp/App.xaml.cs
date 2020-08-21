using System;
using System.IO;
using Xamarin.Forms;
using MobileApp.Data;

namespace MobileApp
{
    public partial class App : Application
    {
        static IssueDatabase database;

        public static IssueDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new IssueDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MobileApp.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MobileAppPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}