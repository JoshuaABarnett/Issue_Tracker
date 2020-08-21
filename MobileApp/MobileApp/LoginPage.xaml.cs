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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void OnLoginClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListIssuesPage());
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MobileAppPage());
        }
    }
}