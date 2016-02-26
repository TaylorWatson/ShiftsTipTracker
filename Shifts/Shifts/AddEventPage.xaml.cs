using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Shifts
{
	public partial class AddEventPage : ContentPage
	{
		public AddEventPage ()
		{
			var shiftTitle = new Entry { Placeholder = "Title", Keyboard = Keyboard.Default};
			var shiftLocation = new Entry { Placeholder = "Location", Keyboard = Keyboard.Email};
			Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
			{
				{ "Aqua", Color.Aqua }, { "Black", Color.Black },
				{ "Gray", Color.Gray }, { "Green", Color.Green },
				{ "Lime", Color.Lime }, { "Maroon", Color.Maroon },
				{ "Navy", Color.Navy }, { "Olive", Color.Olive },
				{ "Purple", Color.Purple }, { "Red", Color.Red },
				{ "Silver", Color.Silver }, { "Teal", Color.Teal },
				{ "White", Color.White }, { "Yellow", Color.Yellow }
			};

			Picker picker = new Picker
			{
				Title = "Color",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			DatePicker datePicker = new DatePicker {
				Format = "D",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			foreach (string colorName in nameToColor.Keys)
			{
				picker.Items.Add(colorName);
			}

			BoxView boxView = new BoxView
			{
				WidthRequest = 150,
				HeightRequest = 150,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			picker.SelectedIndexChanged += (sender, args) =>
			{
				if (picker.SelectedIndex == -1)
				{
					boxView.Color = Color.Default;
				}
				else
				{
					string colorName = picker.Items[picker.SelectedIndex];
					boxView.Color = nameToColor[colorName];
				}
			};

			Content = new StackLayout {
				Padding = new Thickness (20),
				Children = {
					shiftTitle,
					shiftLocation,
					datePicker,
					picker,
					boxView
				}
			};




	}
}
}
