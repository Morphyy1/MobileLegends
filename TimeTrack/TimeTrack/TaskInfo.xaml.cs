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
    public partial class TaskInfo : ContentPage
    {
        public int TaskAcceptNumbet;
        public TaskInfo()
        {
            InitializeComponent();
        }

        public TaskInfo(Tasks task)
        {
            InitializeComponent();
            TaskAcceptNumbet = task.Numeration;
            TaskName.Text = task.TaskName.Text;
            taskColor.BackgroundColor = task.TaskColor;
            Info.Text = task.Description.Text;
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var profile = new Profile();
            NavigationPage.SetHasNavigationBar(profile, false);
            await Navigation.PushAsync(profile, true);
        }

        private async void AcceptButton(object sender, EventArgs e)
        {
            var home = new HomePage(TaskAcceptNumbet);
            NavigationPage.SetHasNavigationBar(home, false);
            await Navigation.PushAsync(home, true);
        }

        private async void BackButton(object sender, EventArgs e)
        {
            var home = new HomePage();
            NavigationPage.SetHasNavigationBar(home, false);
            await Navigation.PushAsync(home, true);
        }
    }
}