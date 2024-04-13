using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            var home = new HomePage();
            NavigationPage.SetHasNavigationBar(home, false);
            await Navigation.PushAsync(home, true);
        }

        private async void newAccountButton_Clicked(object sender, EventArgs e)
        {
            var register = new RegisterPage();
            NavigationPage.SetHasNavigationBar(register, false);
            await Navigation.PushAsync(register, true);
        }
    }
}