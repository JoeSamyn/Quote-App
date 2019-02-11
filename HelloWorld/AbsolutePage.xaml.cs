using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();

            //Absolute Layout in Code
            var layout = new AbsoluteLayout();
            Content = layout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox, 
                                new Rectangle(0, 0, 1, 1),
                                AbsoluteLayoutFlags.All);
            // Set layout bounds after instantiation
            //AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));
            // Set flag parameters after instantiation
            //AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);

            var button = new Button { BackgroundColor = Color.Silver, TextColor=Color.White, Text="Get Started"};
            AbsoluteLayout.SetLayoutFlags(button, AbsoluteLayoutFlags.WidthProportional);
            layout.Children.Add(button,
                                new Rectangle(0, 1, 1, .1),
                                AbsoluteLayoutFlags.All);

            var whiteBox = new BoxView { Color = Color.White };
            layout.Children.Add(whiteBox
                                , new Rectangle(.5, .1, 100, 100)
                                , AbsoluteLayoutFlags.PositionProportional);

        }
    }
}
