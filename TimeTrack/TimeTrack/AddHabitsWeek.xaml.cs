using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddHabits : ContentPage
    {
        static readonly Color defaultColor = Color.FromRgb(235, 235, 235);
        public static Color first = defaultColor;
        public static Color second = defaultColor;
        public static Color third = defaultColor;
        public static Color fourth = defaultColor;
        public static Color fifth = defaultColor;
        public static Color sixth = defaultColor;
        public static Color seventh = defaultColor;


        public AddHabits()
        {
            InitializeComponent();
            firstDate.BackgroundColor = first;
            secondDate.BackgroundColor = second;
            thirdDate.BackgroundColor = third;
            fourthDate.BackgroundColor = fourth;
            fifthDate.BackgroundColor = fifth;
            sixthDate.BackgroundColor = sixth;
            seventhDate.BackgroundColor = seventh;
        }

        private async void addTask1_Clicked(object sender, EventArgs e)
        {
            if (firstDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 1;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            }
        }

        private async void addTask2_Clicked(object sender, EventArgs e)
        {
            if (secondDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 2;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);

            }
        }

        private async void addTask3_Clicked(object sender, EventArgs e)
        {
            if (thirdDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 3;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            } 
        }

        private async void addTask4_Clicked(object sender, EventArgs e)
        {
            if (fourthDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 4;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            }
        }

        private async void addTask5_Clicked(object sender, EventArgs e)
        {
            if (fifthDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 5;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            }
        }

        private async void addTask6_Clicked(object sender, EventArgs e)
        {
            if (sixthDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 6;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            }
        }

        private async void addTask7_Clicked(object sender, EventArgs e)
        {
            if (seventhDate.BackgroundColor == defaultColor)
            {
                var add = new AddTask();
                add.FateNumber = 7;
                NavigationPage.SetHasNavigationBar(add, false);
                await Navigation.PushAsync(add, true);
            }
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