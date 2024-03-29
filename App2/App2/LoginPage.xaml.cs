using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("TimeTrack.logo.png");
            loginButton.BackgroundColor = Color.Transparent;
            registerButton.BackgroundColor = Color.Transparent;
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            var days = new DaysPage();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(days, false);
            await Navigation.PushAsync(days, true);
        }

        private async void registerButton_Clicked(object sender, EventArgs e)
        {
            var register = new RegisterPage();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(register, false);
            await Navigation.PushAsync(register, true);
        }
    }

}