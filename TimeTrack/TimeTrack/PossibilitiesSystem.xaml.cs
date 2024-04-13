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
    public partial class PossibilitiesSystem : ContentPage
    {
        public PossibilitiesSystem()
        {
            InitializeComponent();
        }

        private async void next_Clicked(object sender, EventArgs e)
        {
            var next = new PossibilitiesHabits();
            NavigationPage.SetHasNavigationBar(next, false);
            await Navigation.PushAsync(next, false);
        }
    }
}