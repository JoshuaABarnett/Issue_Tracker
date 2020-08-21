using System;
using System.IO;
using Xamarin.Forms;
using MobileApp.Models;

namespace MobileApp
{
    public partial class IssueEntryPage : ContentPage
    {
        public IssueEntryPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var issue = (Issue)BindingContext;
            issue.CreationDate = DateTime.UtcNow;
            await App.Database.SaveIssueAsync(issue);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var issue = (Issue)BindingContext;
            await App.Database.DeleteIssueAsync(issue);
            await Navigation.PopAsync();
        }
    }
}