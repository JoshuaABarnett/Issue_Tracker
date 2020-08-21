using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        async void OnCreateAccountClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccountPage
            {
                BindingContext = new Account()
            });
        }
    }
}