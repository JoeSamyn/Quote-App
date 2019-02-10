using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 30, 0, 0);
                    break;
            }

            paragraph.Text = "This was shot yesterday in Phoenix, AZ. When I was" +
                "driving home I saw this beautiful landscape and had to take a" +
                "picture.";
        }
    }
}
