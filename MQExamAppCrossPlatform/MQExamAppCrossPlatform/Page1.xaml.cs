using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MQExamAppCrossPlatform
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public static decimal firstNo { get; set; }
        public static decimal secondNo { get; set; }
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isMatch1 = true;
            bool isMatch2 = true;
            
            if (EditText1.Text == null)
            {
                EditText1.Text = "0";
            }
            if (EditText2.Text == null)
            {
                EditText2.Text = "0";
            }
            if (!Regex.IsMatch(EditText1.Text, @"^([0-9]*|\d*\.\d{1}?\d*)$"))
            {
                isMatch1 = false;
            }
            if (!Regex.IsMatch(EditText2.Text, @"^([0-9]*|\d*\.\d{1}?\d*)$"))
            {
                isMatch2 = false;
            }

            if (!isMatch1)
            {
                lblError1.IsVisible = true;
            }
            else { lblError1.IsVisible = false; }

            if (!isMatch2)
            { 
                lblError2.IsVisible = true; 
            }
            else 
            { 
                lblError2.IsVisible = false; 
            }


            if (!isMatch1 || !isMatch2)
            {
                return;
            }
            else
            {
                firstNo = Convert.ToDecimal(EditText1.Text);
                secondNo = Convert.ToDecimal(EditText2.Text);
                Application.Current.MainPage = new NavigationPage(new Page2());
            }
        }
    }
}