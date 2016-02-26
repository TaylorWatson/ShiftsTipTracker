using System;
using XLabs.Forms.Controls;
using Xamarin.Forms;

namespace Shifts
{
	public class SetupPage1 : ContentPage
	{
		public SetupPage1 ()
		{
			var Welcome = new Label () {
				Text = "Welcome to Shifts",
				FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
				TextColor = Color.White,
				HeightRequest = 80,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};

			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#00C4DB");

			var logo = new Image { Aspect = Aspect.AspectFit };
			logo.Source = "Logo/logo.png";


			Content = new StackLayout {
				Padding = new Thickness (0, 200, 0, 10),
				Children = {
					Welcome,
					logo
				}
			};

		}
	}
}


