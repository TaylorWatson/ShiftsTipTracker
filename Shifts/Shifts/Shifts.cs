using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shifts
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new SetupPageCarousel ();

			SetupPage6.Finished += IntroFinished;
		}

		private void IntroFinished (object sender, EventArgs e)
		{
			Debug.WriteLine ("Finished!");
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

