using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MQExamAppAndroid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isMatch1 = true;
            bool isMatch2 = true;

            if (!Regex.IsMatch(EditText1.Text, @"^[0-9](\.[0-9]+)?$")){
                isMatch1 = false;
            }
            if (!Regex.IsMatch(EditText2.Text, @"^[0-9](\.[0-9]+)?$"))
            {
                isMatch2 = false;
            }

            if(!isMatch1)
            { lblError1.IsVisible = true;
            }
            else { lblError1.IsVisible = true; }
            if (!isMatch2)
            { lblError2.IsVisible = true;}
            else { lblError2.IsVisible = true; }

            if (!isMatch1 || !isMatch2)
            {
                return;
            }

        }
    }
}