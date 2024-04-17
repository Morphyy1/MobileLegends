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
	public partial class ChoiceHabits : ContentPage
	{
		public ChoiceHabits ()
		{
			InitializeComponent ();
		}

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
			var account = new Profile();
			NavigationPage.SetHasNavigationBar(account, false);
			await Navigation.PushAsync(account, true);
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            var back = new HomePage();
            NavigationPage.SetHasNavigationBar(back, false);
            await Navigation.PushAsync(back, true);
        }
    }
}