using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfSchedule.XForms;
using System.Diagnostics;
using SQLite;

namespace Shifts
{
	public class CalendarOverviewPage : ContentPage
	{
		

		public CalendarOverviewPage ()
		{
			Title = "Overview";

			var btnAdd = new ToolbarItem {
				Text = "Add Shift"
			};

			btnAdd.Clicked += (object sender, System.EventArgs e) => 
			{
				Navigation.PushAsync(new ShiftEntry());
			};

			this.ToolbarItems.Add (btnAdd);

			//add layout type
			StackLayout layout = new StackLayout ();

			SfSchedule calendar = new SfSchedule ();
			calendar.ScheduleView = ScheduleView.MonthView;
			calendar.ShowAppointmentsInline = true;
//			calendar.DataSource = shifts;
			DateTime currentDate = DateTime.Now;

			calendar.HorizontalOptions = LayoutOptions.FillAndExpand;
			calendar.HeightRequest = 400;

			ScheduleAppointmentCollection shiftCollection = new ScheduleAppointmentCollection ();
			ScheduleAppointment shiftEntry = new ScheduleAppointment ();

			try {
				SQLiteConnection db = (SQLiteConnection) DependencyService.Get<ISQLite> ().GetConnection ();
				IEnumerable<Shift> shifts = db.Query<Shift>("SELECT * FROM [Shift]");
				foreach (Shift s in shifts) 
				{

					shiftEntry.StartTime = s.startTime.DateTime;
					shiftEntry.EndTime = s.endTime.DateTime;
					shiftEntry.Color = Color.Red;
					shiftEntry.Subject = s.shiftTitle;
					shiftEntry.Location = s.shiftLocation;
					shiftCollection.Add (shiftEntry);

				}
			} catch (Exception e) {
				
			}

			calendar.DataSource = shiftCollection;

			layout.Children.Add (calendar);

			Content = layout;

		}
	}
}

