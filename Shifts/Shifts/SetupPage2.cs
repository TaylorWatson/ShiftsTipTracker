using System;

using Xamarin.Forms;

namespace Shifts
{
	public class SetupPage2 : ContentPage
	{
		public SetupPage2 ()
		{
			var header = new Label () {
				Text = "Your personal shift & tip tracker",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			//need to fix this. 
			var myImage = new Image { Source = "Images/iPhone6Plus.png" };
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#00C4DB");


			Content = new StackLayout {
				Children = {
					header
				}
			};
		}
	}
}


