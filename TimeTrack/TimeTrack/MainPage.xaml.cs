using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TimeTrack
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void moveNext_Clicked(object sender, EventArgs e)
        {
            var login = new Possibilities();
            NavigationPage.SetHasNavigationBar(login, false);
            await Navigation.PushAsync(login, true);
        }
    }
}
