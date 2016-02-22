using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Shifts
{
	public partial class AddEventPage : ContentPage
	{
		public ContentPage cp;
		public AddEventPage ()
		{
			InitializeComponent ();

			cp = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to second page!"
						}
					}
				}
			};

		}

		public ContentPage getPage() {
			return cp;
		}




	}
}

