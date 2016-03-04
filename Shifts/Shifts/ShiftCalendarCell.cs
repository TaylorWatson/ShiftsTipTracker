using System;

using Xamarin.Forms;

namespace Shifts
{
	public class ShiftCalendarCell : ContentPage
	{
		public ShiftCalendarCell ()
		{
			var titleLabel = new Label {
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.Center
			};
				
			titleLabel.SetBinding (Label.TextProperty, "Title");
		
			var subjectLabel = new Label {
				VerticalTextAlignment = TextAlignment.Center,
				HorizontalOptions = LayoutOptions.Center
			};

			subjectLabel.SetBinding (Label.TextProperty, "Subject");

			var layout = new StackLayout {
				Padding = new Thickness (20, 0, 20, 0),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { titleLabel, subjectLabel }
			};

			Content = layout;

				
		}
	}
}


