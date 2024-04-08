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
    public partial class AddTaskForMonth : ContentPage
    {
        private Color OriginalColor;

        public AddTaskForMonth()
        {
            InitializeComponent();
            OriginalColor = Color.FromRgb(217, 217, 217);
        }

        private void acceptButton1_Clicked(object sender, EventArgs e)
        {
            SetButtonColor(acceptButton1, acceptButton2,
                acceptButton3, acceptButton4);
        }

        private void acceptButton2_Clicked(object sender, EventArgs e)
        {
            SetButtonColor(acceptButton2, acceptButton1,
                acceptButton3, acceptButton4);
        }

        private void acceptButton3_Clicked(object sender, EventArgs e)
        {
            SetButtonColor(acceptButton3, acceptButton1,
                acceptButton2, acceptButton4);
        }

        private void acceptButton4_Clicked(object sender, EventArgs e)
        {
            SetButtonColor(acceptButton4, acceptButton1,
                acceptButton2, acceptButton3);
        }

        private async void backbutton_Clicked(object sender, EventArgs e)
        {
            var setWeek = new SetMonth();
            NavigationPage.SetHasNavigationBar(setWeek, false);
            await Navigation.PushAsync(setWeek, true);
        }

        private void SetButtonColor(Button colorB1, Button b2, Button b3, Button b4)
        {
            colorB1.BackgroundColor = OriginalColor;
            b2.BackgroundColor = Color.Gray;
            b3.BackgroundColor = Color.Gray;
            b4.BackgroundColor = Color.Gray;
        }
    }
}