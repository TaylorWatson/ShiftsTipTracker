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
				TextColor = Color.White,
				HeightRequest = 50,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
					
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#f4890c");

			//set for all iphone display sizes.
			var chart = new Image { Aspect = Aspect.AspectFit };
			chart.Source = "SetupImages/chart.png";

			//added some padding to top to drop the fon't down.
			Content = new StackLayout {
				Padding = new Thickness (0, 200, 0, 10),
				Children = {
					header,
					chart
				}
			};
		}
	}
}


