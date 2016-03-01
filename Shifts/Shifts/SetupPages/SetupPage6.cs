using System;
using System.Runtime.Serialization;
using Xamarin.Forms;

namespace Shifts	
{

	public class SetupPage6 : ContentPage
	{
		public static event EventHandler Finished;
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
				Text = "Setup Permissions",
				TextColor = Color.White,
				BorderColor = Color.White,
				FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Button)),
			};

			button.Clicked += (object sender, EventArgs e) => {
				if (Finished != null) {
					Finished(sender, e);
				}
			};
			
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#f4890c");


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


