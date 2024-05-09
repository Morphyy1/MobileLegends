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
        public Frame first;
        public Frame second;
        public Frame third;
        public Frame fourth;
        public Frame fifth;
        public Frame sixth;
        public Frame seventh;


        public AddHabits()
        {
            InitializeComponent();
            first = firstDate;
            second = secondDate;
            third = thirdDate;
            fourth = fourthDate;
            fifth = fifthDate; 
            sixth = sixthDate;
            seventh = seventhDate;
        }

        private async void addTask1_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 1;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask2_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 2;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask3_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 3;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask4_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 4;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask5_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 5;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask6_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 6;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void addTask7_Clicked(object sender, EventArgs e)
        {
            var add = new AddTask();
            add.FateNumber = 7;
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
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