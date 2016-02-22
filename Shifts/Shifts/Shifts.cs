using System;
using Xamarin.Forms;

namespace Shifts
{
	public class App : Application
	{
		public App ()
		{
			Label label = new Label {
				XAlign = TextAlignment.Center,
				Text = "Welcome to Shifts!"
			};

			Button b = new Button ();
			b.Text = "Hello";
			b.Clicked += OnCallHistory;

			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						label,
						b
					}
				}
			};





		}

		void OnCallHistory(object sender, EventArgs e)
		{
			ContentPage cp = new AddEventPage ().getPage ();
			MainPage = cp;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

