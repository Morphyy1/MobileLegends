using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("TimeTrack.logo.png");
            buttonMain.BackgroundColor = Color.Transparent;
        }

        private async void buttonMain_Clicked(object sender, EventArgs e)
        {
            var loginPage = new Page1();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(loginPage, false);
            await Navigation.PushAsync(loginPage, true);
        }
    }
}
