using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTask : ContentPage
    {
        public int FateNumber;
        private Color color;


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
            if (HomePage.IterationsCount == 10)
                await DisplayAlert("", "Сначала нужно закончить предыдущие задачи", "Продолжить");

            else if ((FirstChoice.BackgroundColor != Color.Transparent ||
                SecondChoice.BackgroundColor != Color.Transparent ||
                ThirdChoice.BackgroundColor != Color.Transparent || 
                FourthChoice.BackgroundColor != Color.Transparent) &&
                TaskName.Text != "")
            {
                
                switch (FateNumber)
                {
                    case 1:
                        AddHabits.first = color;
                        break;
                    case 2:
                        AddHabits.second = color;
                        break;
                    case 3:
                        AddHabits.third = color;
                        break;
                    case 4:
                        AddHabits.fourth = color;
                        break;
                    case 5:
                        AddHabits.fifth = color;
                        break;
                    case 6:
                        AddHabits.sixth = color;
                        break;
                    case 7:
                        AddHabits.seventh = color;
                        break;
                }

                HomePage.IterationsCount++;
                HomePage.TaskInformations[HomePage.IterationsCount].TaskName.Text = TaskName.Text;
                HomePage.TaskInformations[HomePage.IterationsCount].TaskColor = color;
                HomePage.TaskInformations[HomePage.IterationsCount].Description.Text = TaskDiskription.Text;
                var save = new AddHabits();
                NavigationPage.SetHasNavigationBar(save, false);
                await Navigation.PushAsync(save, true);
            }
        }

        private async void cancelButton_Clicked(object sender, EventArgs e)
        {
            var cancel = new AddHabits();
            NavigationPage.SetHasNavigationBar(cancel, false);
            await Navigation.PushAsync(cancel, true);
        }

        private void FirstButton(object sender, EventArgs e)
        {
            color = Color.FromRgb(115, 113, 252);
            SetColorCgoice(FirstChoice, FourthChoice, ThirdChoice, SecondChoice);
        }

        private void SecondButton(object sender, EventArgs e)
        {
            color = Color.FromRgb(165, 148, 249);
            SetColorCgoice(SecondChoice, FourthChoice, ThirdChoice, FirstChoice);
        }
        private void ThirdButton(object sender, EventArgs e)
        {
            color = Color.FromRgb(205, 193, 255);
            SetColorCgoice(ThirdChoice, FourthChoice, SecondChoice, FirstChoice);
        }
        private void FourthButton(object sender, EventArgs e)
        {
            color = Color.FromRgb(224, 205, 255);
            SetColorCgoice(FourthChoice, ThirdChoice, SecondChoice, FirstChoice);
        }

        private void SetColorCgoice(BoxView choice, BoxView a, BoxView b, BoxView c)
        {
            choice.BackgroundColor = Color.FromRgb(217, 217, 217);
            a.BackgroundColor = Color.Transparent;
            b.BackgroundColor = Color.Transparent;
            c.BackgroundColor = Color.Transparent;
        }
    }
}