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
		public SfSchedule calendar;

		public CalendarOverviewPage ()
		{
			Title = "Overview";

			var btnAdd = new ToolbarItem {
				Text = "Add Shift"
			};

			btnAdd.Clicked += (object sender, System.EventArgs e) => 
			{
				Navigation.PushAsync(new ShiftEntry(this));
			};

			this.ToolbarItems.Add (btnAdd);

			//add layout type
			StackLayout layout = new StackLayout ();

			calendar = new SfSchedule ();
			calendar.ScheduleView = ScheduleView.MonthView;
			calendar.ShowAppointmentsInline = true;
//			calendar.DataSource = shifts;
			DateTime currentDate = DateTime.Now;

			UpdateCalendar ();

			calendar.HorizontalOptions = LayoutOptions.FillAndExpand;
			calendar.HeightRequest = 400;

			layout.Children.Add (calendar);

			Content = layout;

		}

		public void UpdateCalendar() {


			ScheduleAppointmentCollection shiftCollection = new ScheduleAppointmentCollection ();

			try {
				SQLiteConnection db = (SQLiteConnection) DependencyService.Get<ISQLite> ().GetConnection ();
				IEnumerable<Shift> shifts = db.Query<Shift>("SELECT * FROM [Shift]");
				foreach (Shift s in shifts) 
				{
					ScheduleAppointment shiftEntry = new ScheduleAppointment ();
					shiftEntry.StartTime = s.startTime.DateTime;
					shiftEntry.EndTime = s.endTime.DateTime;
					shiftEntry.Color = Color.Red;
					shiftEntry.Subject = s.shiftTitle;
					shiftEntry.Location = s.shiftLocation;
					shiftCollection.Add (shiftEntry);
				}

				calendar.DataSource = shiftCollection;
			} catch (Exception e) {

			}


		}
	}
}

