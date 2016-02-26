using System;

using Xamarin.Forms;

namespace Shifts
{
	public class SetupPage3 : ContentPage
	{
		public SetupPage3 ()
		{
			var header = new Label () {
				Text = "Start your shift",
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


