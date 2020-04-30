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
	public partial class AddImageFromResourceFolder : ContentPage
	{
		public AddImageFromResourceFolder ()
		{
			InitializeComponent ();
           // Image1.Source =ImageSource.FromFile( "HelloWorldApp.IMages.image1.jpg");
            
		}
	}
}