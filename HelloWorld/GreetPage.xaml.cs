using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {

        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        Padding = new Thickness(0, 50, 0, 0);
            //        break;

            //    case Device.Android:
            //        Padding = 0;
            //        break;

            //}
        }

    }
}
