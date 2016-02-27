using System;

using Xamarin.Forms;

namespace Shifts
{
	public class SetupPageCarousel : CarouselPage
	{

		public SetupPageCarousel ()
		{
			this.Children.Add (new SetupPage1 ());
			this.Children.Add (new SetupPage2 ());
			this.Children.Add (new SetupPage3 ());
			this.Children.Add (new SetupPage4 ());
			this.Children.Add (new SetupPage5 ());
			this.Children.Add (new SetupPage6 ());
		}


	}
}


