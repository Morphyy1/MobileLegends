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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			InitializeComponent();
            logo.Source = ImageSource.FromResource("TimeTrack.logo.png");
        }

        private async void Accept(object sender, EventArgs e)
        {
            var daysPage = new DaysPage();
            NavigationPage.SetHasNavigationBar(daysPage, false);
            await Navigation.PushAsync(daysPage, true);
        }

        private async void LoginPage(object sender, EventArgs e)
        {
            var loginPage = new Page1();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(loginPage, false);
            await Navigation.PushAsync(loginPage, true);
        }
    }
}