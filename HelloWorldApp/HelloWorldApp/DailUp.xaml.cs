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
	public partial class DailUp : ContentPage
	{
		public DailUp ()
		{
			InitializeComponent ();


            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});

            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});
            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});
            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});
            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});
            myGrid.RowDefinitions.Add( new RowDefinition { Height=new GridLength(1,GridUnitType.Star)});

            myGrid.ColumnDefinitions.Add(new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star) });
            myGrid.ColumnDefinitions.Add(new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star) });
            myGrid.ColumnDefinitions.Add(new ColumnDefinition {Width=new GridLength(1,GridUnitType.Star) });

            

            drawGrid(myGrid);

         
        }
        Label label = new Label() {TextColor=Color.White,FontSize=20 };
        private void drawGrid(Grid myGrid)
        {  

            var btnList = new List<Button> { };
           

            for (int i = 0; i < 10; i++)
            { var btn = new Button();
                btn.Text = i.ToString();
                btn.CornerRadius = 12;
                btn.BackgroundColor = Color.White;
                btn.Clicked += Button_Clicked;
                btnList.Add(btn);               
            }

          
            
            myGrid.Children.Add(label, 0, 0);

            Grid.SetColumnSpan(label, 3);

            myGrid.Children.Add(btnList.ElementAt(0), 1, 4);
            myGrid.Children.Add(btnList.ElementAt(1), 0, 1);
            myGrid.Children.Add(btnList.ElementAt(2), 1, 1);
            myGrid.Children.Add(btnList.ElementAt(3), 2, 1);

            myGrid.Children.Add(btnList.ElementAt(4), 0, 2);
            myGrid.Children.Add(btnList.ElementAt(5), 1, 2);
            myGrid.Children.Add(btnList.ElementAt(6), 2, 2);

            myGrid.Children.Add(btnList.ElementAt(7), 0, 3);
            myGrid.Children.Add(btnList.ElementAt(8), 1, 3);
            myGrid.Children.Add(btnList.ElementAt(9), 2, 3);

            var Dailbtn = new Button { Text = "Dail", BackgroundColor = Color.LightGreen,TextColor=Color.White };
            myGrid.Children.Add(Dailbtn,0,5);
            Grid.SetColumnSpan(Dailbtn, 3);
        }

    
        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            label.Text+= btn.Text;
        }
    }
}