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
    public partial class PossibilitiesHabits : ContentPage
    {
        public PossibilitiesHabits()
        {
            InitializeComponent();
        }

        private async void next_Clicked(object sender, EventArgs e)
        {
            var next = new LoginPage();
            NavigationPage.SetHasNavigationBar(next, false);
            await Navigation.PushAsync(next, true);
        }
    }
}