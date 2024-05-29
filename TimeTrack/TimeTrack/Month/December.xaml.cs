using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack.Month
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class December : ContentPage
	{
		public December ()
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

        private async void weekButton_Clicked(object sender, EventArgs e)
        {
            var week = new AddHabits();
            NavigationPage.SetHasNavigationBar(week, false);
            await Navigation.PushAsync(week, false);
        }

        private async void ChooseAMonth_Clicked(object sender, EventArgs e)
        {
            var months = new ChooseAMonth();
            NavigationPage.SetHasNavigationBar(months, false);
            await Navigation.PushAsync(months, false);
        }

        private async void AddTaskClicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }
    }
}