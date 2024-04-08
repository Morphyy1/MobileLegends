using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrack;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DaysPage : ContentPage
    {
        public DaysPage()
        {
            InitializeComponent();
        }

        private async void SetDayPlane(object sender, EventArgs e)
        {
            var setDay = new SetDay();
            NavigationPage.SetHasNavigationBar(setDay, false);
            await Navigation.PushAsync(setDay, true);
        }

        private async void SetWeekPlane(object sender, EventArgs e)
        {
            var setWeek = new SetWeek();
            NavigationPage.SetHasNavigationBar(setWeek, false);
            await Navigation.PushAsync(setWeek, true);
        }

        private async void SetMonthPlane(object sender, EventArgs e)
        {
            var setMonth = new SetMonth();
            NavigationPage.SetHasNavigationBar(setMonth, false);
            await Navigation.PushAsync(setMonth, true);
        }

        private async void settingButton_Clicked(object sender, EventArgs e)
        {
            var settings = new Settings();
            NavigationPage.SetHasNavigationBar(settings, false);
            await Navigation.PushAsync(settings, true);
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var ach = new Achivment();
            NavigationPage.SetHasNavigationBar(ach, false);
            await Navigation.PushAsync(ach, true);
        }
    }
}
