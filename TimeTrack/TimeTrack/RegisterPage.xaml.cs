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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void createAccountButton_Clicked(object sender, EventArgs e)
        {
            var home = new HomePage();
            NavigationPage.SetHasNavigationBar(home, false);
            await Navigation.PushAsync(home, true);
        }

        private async void backLoginButton_Clicked(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            NavigationPage.SetHasNavigationBar(loginPage, false);
            await Navigation.PushAsync(loginPage, true);
        }
    }
}