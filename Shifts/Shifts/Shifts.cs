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
					MainPage = new NavigationPage(new CalendarOverviewPage ());
				}

			} catch (KeyNotFoundException KnfE) {

				String s = KnfE.Message; // Just to suppress 'KnfE never used' error message.
				//MainPage = new SetupPageCarousel ();
				MainPage = new NavigationPage(new CalendarOverviewPage ());
				SetupPage6.Finished += IntroFinished;

			}
				
		}

		private void IntroFinished (object sender, EventArgs e)
		{
			MainPage = new NavigationPage(new CalendarOverviewPage ());
			SetupPage6.Finished -= IntroFinished;
			Properties ["app_status"] = INTRO_FINISHED;
		}

		protected override void OnStart ()
		{
			Debug.WriteLine ("OnStart");
		}

		protected override void OnSleep ()
		{
			Debug.WriteLine ("OnSleep");
		}

		protected override void OnResume ()
		{
			Debug.WriteLine ("OnResume");
		}
	}
}

