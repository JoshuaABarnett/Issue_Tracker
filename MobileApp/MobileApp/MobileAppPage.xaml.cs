using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using MobileApp.Models;

namespace MobileApp
{
    public partial class MobileAppPage : ContentPage
    {
        public MobileAppPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetMobileAppAsync();
        }
        async void OnIssueAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IssueEntryPage
            {
                BindingContext = new Issue()
            });
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new IssueEntryPage
                {
                    BindingContext = e.SelectedItem as Issue
                });
            }
        }
        async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccountPage
            {
                BindingContext = new Account()
            });
        }
        async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        async void OnEnterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListIssuesPage());
        }
    }
}