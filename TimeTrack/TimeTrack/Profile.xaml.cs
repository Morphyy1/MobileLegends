﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Profile : ContentPage
	{
		public Profile ()
		{
			InitializeComponent ();
		}

        private async void habitButton_Clicked(object sender, EventArgs e)
        {
			var habits = new ChoiceHabits();
			NavigationPage.SetHasNavigationBar(habits, false);
			await Navigation.PushAsync(habits, false);
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            var back = new HomePage();
            NavigationPage.SetHasNavigationBar(back, false);
            await Navigation.PushAsync(back, false);
        }
    }
}