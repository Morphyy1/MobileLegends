using App2;
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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
		}

        private async void backbutton_Clicked(object sender, EventArgs e)
        {
            var days = new DaysPage();
            NavigationPage.SetHasNavigationBar(days, false);
            await Navigation.PushAsync(days, true);
        }
    }
}