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
    public partial class Achivment : ContentPage
    {
        public Achivment()
        {
            InitializeComponent();
        }

        private async void ExitClicked(object sender, EventArgs e)
        {
            var days = new DaysPage();
            NavigationPage.SetHasNavigationBar(days, false);
            await Navigation.PushAsync(days, true);
        }
    }
}