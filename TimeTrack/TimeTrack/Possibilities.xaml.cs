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
    public partial class Possibilities : ContentPage
    {
        public Possibilities()
        {
            InitializeComponent();
        }

        private async void next_Clicked(object sender, EventArgs e)
        {
            var next = new PossibilitiesTask();
            NavigationPage.SetHasNavigationBar(next, false);
            await Navigation.PushAsync(next, false);
        }
    }
}