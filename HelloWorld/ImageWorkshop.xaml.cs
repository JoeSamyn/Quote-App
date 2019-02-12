using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ImageWorkshop : ContentPage
    {
        public ImageWorkshop()
        {
            InitializeComponent();

            //Adding image by URI
            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            // image caching stores the image in computer cache for an extended amount of time. 
            // Here it is false because we want it to update incase the image is changed. 
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;

            // Image from resource folder named images.  Right click switch buildAction to EmbeddedResource, then go to properties
            // and copy and paste the Image ID in the FromResource method like below. 
            //image.Source = ImageSource.FromResource("HelloWorld.Images.computer.jpg");

            // Can set in code behind or XAML
            //Aspect.Fill fills whole display area, used for background images. 
            //  
            //image.Aspect = Aspect.AspectFill;

            //btn.Image = (FileImageSource) ImageSource.FromFile("clock.png");
        }
    }
}
/*
 * <!--<AbsoluteLayout>
        <ActivityIndicator IsRunning="{Binding Source={x:Reference image}, Path=IsLoading}"
                           AbsoluteLayout.LayoutBounds="0.5, 0.5, 100, 100"
                           AbsoluteLayout.LayoutFlags="PositionProportional"/>
        <Image x:Name="image"
               AbsoluteLayout.LayoutBounds="0, 0, 1, 1"
               AbsoluteLayout.LayoutFlags="All"/>
    </AbsoluteLayout>-->
 */
