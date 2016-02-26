using System;

using Xamarin.Forms;

namespace Shifts
{
	public class SetupPage6 : ContentPage
	{
		public SetupPage6 ()
		{
			var header = new Label () {
				Text = "Let's get started",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,
				HeightRequest = 200,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			var button = new Button () {
				Text = "Add Permissions",
				TextColor = Color.White,
				BorderColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Button)),
			};

			//need to fix this. 
			var myImage = new Image { Source = "Images/iPhone6Plus.png" };
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#00C4DB");


			Content = new StackLayout {
				Padding = new Thickness (0, 200, 0, 10),
				Children = {
					header,
					button
				}
			};
		}
	}
}


