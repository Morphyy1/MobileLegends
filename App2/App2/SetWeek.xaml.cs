﻿using App2;
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
	public partial class SetWeek : ContentPage
	{
		public SetWeek ()
		{
			InitializeComponent ();
		}

        private async void backbutton_Clicked(object sender, EventArgs e)
        {
            var days = new DaysPage();
            NavigationPage.SetHasNavigationBar(days, false);
            await Navigation.PushAsync(days, true);
        }

        private async void accountbutton_Clicked(object sender, EventArgs e)
        {
            var ach = new Achivment();
            NavigationPage.SetHasNavigationBar(ach, false);
            await Navigation.PushAsync(ach, true);
        }

        private async void addTask_Clicked(object sender, EventArgs e)
        {
            var tasksOnWeek = new AddTaskForWeek();
            NavigationPage.SetHasNavigationBar(tasksOnWeek, false);
            await Navigation.PushAsync(tasksOnWeek, true);
        }
    }
}