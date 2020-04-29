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
	public partial class RelativeLayoutTest : ContentPage
	{
		public RelativeLayoutTest ()
		{
			InitializeComponent ();
            var layout = new RelativeLayout{ };
            Content = layout;

            var boxView = new BoxView { BackgroundColor = Color.Gray };
            layout.Children.Add(boxView,
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

            var button = new Button { BackgroundColor = Color.DarkRed };
            layout.Children.Add(button,
                xConstraint: Constraint.RelativeToView(boxView, (RelativeLayout, element) => element.Width * 0.5),
                yConstraint: Constraint.RelativeToView(boxView, (RelativeLayout, ele) => ele.Height * 0.5));

        }
	}
}