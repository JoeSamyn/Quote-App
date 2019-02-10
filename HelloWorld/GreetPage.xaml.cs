using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{

    public partial class GreetPage : ContentPage
    {
        int index = 0;
        private string[] quotes =
        {
             "Whatever the mind of man can conceive and believe, it can" +
             " achieve.",
             "Two roads diverged in a wood, and I—I took the one less " +
             "traveled by, And that has made all the difference.",
             "I attribute my success to this: I never gave or took any" +
             " excuse.",
             "You miss 100% of the shots you don’t take."
        };

        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 16;
            label.Text = quotes[0];

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            index++;
            if(index >= quotes.Length)
            {
                index = 0;
            }
            label.Text = quotes[index];
        }
    }
}
