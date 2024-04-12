using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var mainPage = new MainPage();
            NavigationPage.SetHasNavigationBar(mainPage, false);
            MainPage = new NavigationPage(mainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
