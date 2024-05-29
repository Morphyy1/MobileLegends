using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TimeTrack
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public static int IterationsCount;
        public static List<Tasks> TaskInformations;
        public int CompleteCount;

        public HomePage()
        {
            InitializeComponent();
            if (IterationsCount == 0)
                SetTasksList();
            SetModificationFrame();
        }

        private void SetTasksList()
        {
            TaskInformations = new List<Tasks>
                {
                    new Tasks(),
                    new Tasks{Task = FirstTask, TaskName = FirstTaskLabe, Description = new Label(), Numeration = 1},
                    new Tasks{Task = SecondTask, TaskName = SecondTaskLabe, Description = new Label(), Numeration = 2},
                    new Tasks{Task = ThirdTask, TaskName = ThirdTaskLabe, Description = new Label(), Numeration = 3},
                    new Tasks{Task = FourthTask, TaskName = FourthTaskLabe, Description = new Label(), Numeration = 4},
                    new Tasks{Task = FifthTask, TaskName = FifthTaskLabe, Description = new Label(), Numeration = 5},
                    new Tasks{Task = SixthTask, TaskName = SixthTaskLabe, Description = new Label(), Numeration = 6},
                    new Tasks{Task = SeventhTask, TaskName = SeventhTaskLabe, Description = new Label(), Numeration = 7},
                    new Tasks{Task = EighthTask, TaskName = EighthTaskLabe, Description = new Label(), Numeration = 8},
                    new Tasks{Task = NinethTask, TaskName = NinethTaskLabe, Description = new Label(), Numeration = 9},
                    new Tasks{Task = TenthTask, TaskName = TenthTaskLabe, Description = new Label(), Numeration = 10},
                };
        }

        public HomePage(int numeration)
        {
            InitializeComponent();
            SetTasksFlag(numeration);
            SetModificationFrame();
        }

        private void SetTasksFlag(int numeration)
        {
            switch (numeration)
            {
                case 1:
                    TaskInformations[1].flag = true;
                    break;
                case 2:
                    TaskInformations[2].flag = true;
                    break;
                case 3:
                    TaskInformations[3].flag = true;
                    break;
                case 4:
                    TaskInformations[4].flag = true;
                    break;
                case 5:
                    TaskInformations[5].flag = true;
                    break;
                case 6:
                    TaskInformations[6].flag = true;
                    break;
                case 7:
                    TaskInformations[7].flag = true;
                    break;
                case 8:
                    TaskInformations[8].flag = true;
                    break;
                case 9:
                    TaskInformations[9].flag = true;
                    break;
                case 10:
                    TaskInformations[10].flag = true;
                    break;
            }
        }

        private void SetModificationFrame()
        {
            if (IterationsCount > 0)
            {
                for (var i = 1; i <= IterationsCount; i++)
                {
                    if (!TaskInformations[i].flag)
                        TaskInformations[i].Task.BorderColor = Color.FromRgb(254, 180, 203);
                    else
                    {
                        TaskInformations[i].Task.BorderColor = Color.FromRgb(190, 255, 159);
                        TaskInformations[i].TaskName.Text = "Выполнено";
                    }
                }
            }
            SetUp();
        }

        private void SetUp()
        {
            FirstTask.BorderColor = TaskInformations[1].Task.BorderColor;
            FirstTaskLabe.Text = TaskInformations[1].TaskName.Text;
            SecondTask.BorderColor = TaskInformations[2].Task.BorderColor;
            SecondTaskLabe.Text = TaskInformations[2].TaskName.Text;
            ThirdTask.BorderColor = TaskInformations[3].Task.BorderColor;
            ThirdTaskLabe.Text = TaskInformations[3].TaskName.Text;
            FourthTask.BorderColor = TaskInformations[4].Task.BorderColor;
            FourthTaskLabe.Text = TaskInformations[4].TaskName.Text;
            FifthTask.BorderColor = TaskInformations[5].Task.BorderColor;
            FifthTaskLabe.Text = TaskInformations[5].TaskName.Text;
            SixthTask.BorderColor = TaskInformations[6].Task.BorderColor;
            SixthTaskLabe.Text = TaskInformations[6].TaskName.Text;
            SeventhTask.BorderColor = TaskInformations[7].Task.BorderColor;
            SeventhTaskLabe.Text = TaskInformations[7].TaskName.Text;
            EighthTask.BorderColor = TaskInformations[8].Task.BorderColor;
            EighthTaskLabe.Text = TaskInformations[8].TaskName.Text;
            NinethTask.BorderColor = TaskInformations[9].Task.BorderColor;
            NinethTaskLabe.Text = TaskInformations[9].TaskName.Text;
            TenthTask.BorderColor = TaskInformations[10].Task.BorderColor;
            TenthTaskLabe.Text = TaskInformations[10].TaskName.Text;
        }

        private async void accountButton_Clicked(object sender, EventArgs e)
        {
            var profile = new Profile();
            NavigationPage.SetHasNavigationBar(profile, false);
            await Navigation.PushAsync(profile, true);
        }

        private async void habitButton_Clicked(object sender, EventArgs e)
        {
            var habits = new ChoiceHabits();
            NavigationPage.SetHasNavigationBar(habits, false);
            await Navigation.PushAsync(habits, true);
        }

        private async void addButton_Clicked(object sender, EventArgs e)
        {
            var add = new AddHabits();
            NavigationPage.SetHasNavigationBar(add, false);
            await Navigation.PushAsync(add, true);
        }

        private async void Info(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button == FirstButton && FirstTask.BorderColor != Color.Transparent &&
                !TaskInformations[1].flag)
            {
                var info = new TaskInfo(TaskInformations[1]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == SecondButton && SecondTask.BorderColor != Color.Transparent &&
                !TaskInformations[2].flag)
            {
                var info = new TaskInfo(TaskInformations[2]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == ThirdButton && ThirdTask.BorderColor != Color.Transparent &&
                !TaskInformations[3].flag)
            {
                var info = new TaskInfo(TaskInformations[3]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == FourthButton && FourthTask.BorderColor != Color.Transparent &&
                !TaskInformations[4].flag)
            {
                var info = new TaskInfo(TaskInformations[4]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == FifthButton && FifthTask.BorderColor != Color.Transparent &&
                !TaskInformations[5].flag)
            {
                var info = new TaskInfo(TaskInformations[5]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == SixthButton && SixthTask.BorderColor != Color.Transparent &&
                !TaskInformations[6].flag)
            {
                var info = new TaskInfo(TaskInformations[6]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == SeventhButton && SeventhTask.BorderColor != Color.Transparent &&
                !TaskInformations[7].flag)
            {
                var info = new TaskInfo(TaskInformations[7]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == EighthButton && EighthTask.BorderColor != Color.Transparent &&
                !TaskInformations[8].flag)
            {
                var info = new TaskInfo(TaskInformations[8]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == NinethButton && NinethTask.BorderColor != Color.Transparent &&
                !TaskInformations[9].flag)
            {
                var info = new TaskInfo(TaskInformations[9]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
            if (button == TenthButton && TenthTask.BorderColor != Color.Transparent &&
                !TaskInformations[10].flag)
            {
                var info = new TaskInfo(TaskInformations[10]);
                NavigationPage.SetHasNavigationBar(info, false);
                await Navigation.PushAsync(info, true);
            }
        }
    }
}