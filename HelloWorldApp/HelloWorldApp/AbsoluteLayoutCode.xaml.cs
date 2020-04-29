using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorldApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsoluteLayoutCode : ContentPage
	{
		public AbsoluteLayoutCode ()
		{
			InitializeComponent ();
            //var layout = new StackLayout { HorizontalOptions=new LayoutOptions {Alignment=LayoutAlignment.Fill },VerticalOptions=new LayoutOptions { Alignment=LayoutAlignment.Fill},BackgroundColor=Color.Silver };

            //Content = layout;

            //var image = new Image { Source = "http://lorempixel.com/1920/1080/nature/7", HorizontalOptions = new LayoutOptions { Alignment = LayoutAlignment.Fill },
            //    VerticalOptions =new LayoutOptions { Alignment = LayoutAlignment.Fill } };
            //layout.Children.Add(image);

            //var absolutLayout = new AbsoluteLayout();
            //absolutLayout.Children.Add(new Button { Text = "Like", TextColor = Color.White });
            //absolutLayout.Children.Add(new Button { Text = "Comment", TextColor = Color.White });
            //absolutLayout.Children.Add(new Button { Text = "Share", TextColor = Color.White });

            var layout = new AbsoluteLayout();
            Content = layout;

            layout.HorizontalOptions = layout.VerticalOptions = new LayoutOptions { Alignment = LayoutAlignment.Fill };
            var image = new Image {Source= "http://lorempixel.com/1920/1080/nature/7/",VerticalOptions=new LayoutOptions {Alignment=LayoutAlignment.Fill ,Expands=true} ,Aspect=Aspect.AspectFill};

            layout.Children.Add(image, new Rectangle(0, 0, 1, 1), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.All);

            var stacklayout = new StackLayout() { BackgroundColor=Color.DarkGray, Opacity=0.5};

            layout.Children.Add(stacklayout, new Rectangle(0.8,1, 1, 0.2), AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(stacklayout, new Rectangle(0.8, 1, 1, 0.2));
            AbsoluteLayout.SetLayoutFlags(stacklayout, AbsoluteLayoutFlags.All);

            stacklayout.Orientation = StackOrientation.Horizontal;
            stacklayout.Children.Add(new Button { Text = "Like", TextColor = Color.CadetBlue, FlowDirection = FlowDirection.LeftToRight,HeightRequest=50 });
            stacklayout.Children.Add(new Button { Text = "Comment", TextColor = Color.CadetBlue, FlowDirection = FlowDirection.LeftToRight, HeightRequest = 50 });
            stacklayout.Children.Add(new Button { Text = "Share", TextColor = Color.CadetBlue, FlowDirection = FlowDirection.LeftToRight, HeightRequest = 50 });
		}
	}
}