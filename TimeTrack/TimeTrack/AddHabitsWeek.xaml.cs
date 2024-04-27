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
    public partial class AddHabits : ContentPage
    {
        public AddHabits()
        {
            InitializeComponent();
        }

        private async void monthButton_Clicked(object sender, EventArgs e)
        {
            var month = new AddHabithMonth();
            NavigationPage.SetHasNavigationBar(month, false);
            await Navigation.PushAsync(month, false);
        }

        private async void backButton_Clicked(object sender, EventArgs e)
        {
            var back = new HomePage();
            NavigationPage.SetHasNavigationBar(back, false);
            await Navigation.PushAsync(back, true);
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var profile = new Profile();
            NavigationPage.SetHasNavigationBar(profile, false);
            await Navigation.PushAsync(profile, true);
        }
    }
}