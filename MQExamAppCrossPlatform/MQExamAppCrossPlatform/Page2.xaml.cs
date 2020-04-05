using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MQExamAppCrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            decimal firstNo = Page1.firstNo;
            decimal secondNo = Page1.secondNo;
            decimal sum = firstNo + secondNo;


            lblResult.Text = "You have entered " + firstNo + " + " + secondNo + " = " + sum ;
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            Application.Current.MainPage = new NavigationPage(new Page1());
            return true;
        }

        private void btn_Back_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());
        }

        private void btn_Exit_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}