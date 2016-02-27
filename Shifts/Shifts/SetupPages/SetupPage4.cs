using System;

using Xamarin.Forms;

namespace Shifts
{
	public class SetupPage4 : ContentPage
	{
		public SetupPage4 ()
		{
			var header = new Label () {
				Text = "Enter your tips",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,
				HeightRequest = 200,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
					
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#00C4DB");

			Content = new StackLayout {
				Padding = new Thickness (0, 200, 0, 10),
				Children = {
					header
				}
			};
		}
	}
}


