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
    public partial class AddTask : ContentPage
    {
        public int FateNumber;
        public AddTask()
        {
            InitializeComponent();
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var profile = new Profile();
            NavigationPage.SetHasNavigationBar(profile, false);
            await Navigation.PushAsync(profile, true);
        }

        private async void saveButton_Clicked(object sender, EventArgs e)
        {
            var save = new AddHabits();
            NavigationPage.SetHasNavigationBar(save, false);
            switch (FateNumber)
            {
                case 1:
                    save.first.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 2:
                    save.second.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 3:
                    save.third.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 4:
                    save.fourth.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 5:
                    save.fifth.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 6:
                    save.sixth.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
                case 7:
                    save.seventh.BackgroundColor = Color.FromRgb(254, 180, 203);
                    break;
            }
            await Navigation.PushAsync(save, true);
        }

        private async void cancelButton_Clicked(object sender, EventArgs e)
        {
            var cancel = new AddHabits();
            NavigationPage.SetHasNavigationBar(cancel, false);
            await Navigation.PushAsync(cancel, true);
        }
    }
}