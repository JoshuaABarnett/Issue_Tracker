using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListIssuesPage : ContentPage
    {
        public ListIssuesPage()
        {
            InitializeComponent();
        }
        async void OnCreateIssueClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateIssuePage());
        }
    }
}