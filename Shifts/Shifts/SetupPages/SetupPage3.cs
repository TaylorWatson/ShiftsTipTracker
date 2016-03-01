﻿using System;

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
				TextColor = Color.White,
				HeightRequest = 200,
				HorizontalOptions = LayoutOptions.CenterAndExpand
			};
					
			//will use just solid BG colour for now.
			BackgroundColor = Color.FromHex("#f4890c");


			Content = new StackLayout {
				Padding = new Thickness (0, 200, 0, 10),
				Children = {
					header
				}
			};
		}
	}
}


