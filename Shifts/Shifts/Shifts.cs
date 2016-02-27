using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Shifts
{
	public class App : Application
	{
		public const string INTRO_FINISHED = "finished";

		public App ()
		{
			try {
				string app_status = (string)Properties ["app_status"];
				if (app_status == INTRO_FINISHED) {
					MainPage = new CalendarOverviewPage ();
				}
			} catch (KeyNotFoundException KnfE) {
				MainPage = new SetupPageCarousel ();
				SetupPage6.Finished += IntroFinished;
			}
				
		}

		private void IntroFinished (object sender, EventArgs e)
		{
			MainPage = new CalendarOverviewPage ();
			SetupPage6.Finished -= IntroFinished;
			Properties ["app_status"] = "finished";
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

