using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class RelLayoutPage : ContentPage
    {
        public RelLayoutPage()
        {
            InitializeComponent();

            var layout = new RelativeLayout();
            Content = layout;

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox,
                                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));
            var silverBox = new BoxView { Color = Color.Silver };
            layout.Children.Add(silverBox,
                                yConstraint: Constraint.RelativeToView(aquaBox, (RelativeLayout, element) => element.Height + 20));
        }
    }
}


/*
 * <RelativeLayout>
        <BoxView BackgroundColor="#f7f7f7"
                 x:Name="banner"
                 RelativeLayout.WidthConstraint="{ConstraintExpression Type=RelativeToParent, Property=Width, Factor=1}"
                 RelativeLayout.HeightConstraint="{ConstraintExpression Type=RelativeToParent, Property=Height, Factor=.3}"/>
        <StackLayout HorizontalOptions="Center"
                     VerticalOptions="Center"
                     RelativeLayout.WidthConstraint="{ConstraintExpression Type=RelativeToParent, Property=Width, Factor=1}"
                     RelativeLayout.HeightConstraint="{ConstraintExpression Type=RelativeToParent, Property=Height, Factor=.3}">
            <Label Text="$11.95"
                   FontSize="60"
                   HorizontalOptions="Center"
                   FontAttributes="Bold"/>
            <Button Text="Add $7.99 Credit"
                    TextColor="White"
                    FontSize="15"
                    FontAttributes="Bold"
                    BorderRadius="15"
                    HeightRequest="30"
                    BackgroundColor="#1695A3"/>
        </StackLayout>
        <StackLayout RelativeLayout.YConstraint="{ConstraintExpression Type=RelativeToView, Property=Height, ElementName=banner, Factor=1, Constant=30}"
                     RelativeLayout.WidthConstraint="{ConstraintExpression Type=RelativeToParent, Property=Width, Factor=1}">
            <Label Text="Why pay for credit?" 
                   FontSize="15"
                   FontAttributes="Bold"
                   HorizontalOptions="Center"/>
            <Label FontSize="13"
                   HorizontalOptions="Center"
                   HorizontalTextAlignment="Center">
                So, the space between the banner and the description is 0.2 of the page height. The bigger the device, the more space between these two elements.
            </Label>
            
        </StackLayout>
    </RelativeLayout>
 */
