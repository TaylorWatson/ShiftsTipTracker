using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Syncfusion.SfCalendar.XForms.iOS;
using Syncfusion.SfSchedule.XForms.iOS;

namespace Shifts.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			//changes all UISwitch controls in the app, makes it ORANGE!
			UISwitch.Appearance.OnTintColor = UIColor.FromRGB(red:0.957, green:0.537, blue:0.047);

			global::Xamarin.Forms.Forms.Init ();

			new SfCalendarRenderer (); 
			new SfScheduleRenderer ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

