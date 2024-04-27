using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrack.Month;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChooseAMonth : ContentPage
	{
		public ChooseAMonth ()
		{
			InitializeComponent ();
		}

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var profile = new Profile();
            NavigationPage.SetHasNavigationBar(profile, false);
            await Navigation.PushAsync(profile, true);
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            var back = new HomePage();
            NavigationPage.SetHasNavigationBar(back, false);
            await Navigation.PushAsync(back, true);
        }

        private async void January_Clicked(object sender, EventArgs e)
        {
            var jenuary = new AddHabithMonth();
            NavigationPage.SetHasNavigationBar(jenuary, false);
            await Navigation.PushAsync(jenuary, false);
        }

        private async void February_Clicked(object sender, EventArgs e)
        {
            var february = new February();
            NavigationPage.SetHasNavigationBar(february, false);
            await Navigation.PushAsync(february, false);
        }

        private async void march_Clicked(object sender, EventArgs e)
        {
            var march = new March();
            NavigationPage.SetHasNavigationBar(march, false);
            await Navigation.PushAsync(march, false);
        }

        private async void april_Clicked(object sender, EventArgs e)
        {
            var april = new April();
            NavigationPage.SetHasNavigationBar(april, false);
            await Navigation.PushAsync(april, false);
        }

        private async void may_Clicked(object sender, EventArgs e)
        {
            var may = new May();
            NavigationPage.SetHasNavigationBar(may, false);
            await Navigation.PushAsync(may, false);
        }

        private async void june_Clicked(object sender, EventArgs e)
        {
            var june = new June();
            NavigationPage.SetHasNavigationBar(june, false);
            await Navigation.PushAsync(june, false);
        }

        private async void july_Clicked(object sender, EventArgs e)
        {
            var july = new July();
            NavigationPage.SetHasNavigationBar(july, false);
            await Navigation.PushAsync(july, false);
        }

        private async void august_Clicked(object sender, EventArgs e)
        {
            var august = new August();
            NavigationPage.SetHasNavigationBar(august, false);
            await Navigation.PushAsync(august, false);
        }

        private async void september_Clicked(object sender, EventArgs e)
        {
            var september = new September();
            NavigationPage.SetHasNavigationBar(september, false);
            await Navigation.PushAsync(september, false);
        }

        private async void october_Clicked(object sender, EventArgs e)
        {
            var october = new October();
            NavigationPage.SetHasNavigationBar(october, false);
            await Navigation.PushAsync(october, false);
        }

        private async void november_Clicked(object sender, EventArgs e)
        {
            var november = new November();
            NavigationPage.SetHasNavigationBar(november, false);
            await Navigation.PushAsync(november, false);
        }

        private async void december_Clicked(object sender, EventArgs e)
        {
            var december = new December();
            NavigationPage.SetHasNavigationBar(december, false);
            await Navigation.PushAsync(december, false);
        }
    }
}