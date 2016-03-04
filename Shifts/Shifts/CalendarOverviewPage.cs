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
		ScheduleAppointmentCollection shiftCollection;
		public SfSchedule calendar;
		public ListView shiftList;

		public CalendarOverviewPage ()
		{

			var btnAdd = new ToolbarItem {
				Text = "Add Shift"
			};

			ToolbarItems.Add(new ToolbarItem("AddShift", "+.png", async () =>
				{
					Navigation.PushAsync(new ShiftEntry(this));
				}));

			ToolbarItems.Add(new ToolbarItem("StartShift", "clock.png", async () =>
				{
					Navigation.PushAsync(new ShiftEntry(this));
				}));


			//add layout type
			StackLayout layout = new StackLayout ();

			calendar = new SfSchedule ();
			calendar.ScheduleView = ScheduleView.MonthView;
			calendar.ShowAppointmentsInline = false;
//			calendar.DataSource = shifts;
			DateTime currentDate = DateTime.Now;

			UpdateCalendar ();

			calendar.HorizontalOptions = LayoutOptions.FillAndExpand;
			calendar.HeightRequest = 400;

			var tipPlus = new Image { Aspect = Aspect.AspectFit };
			tipPlus.Source = "tipPlus.png";



			layout.Children.Add (calendar);
			layout.Children.Add (tipPlus);

			Content = layout;



		}

		public void UpdateCalendar() {


			shiftCollection = new ScheduleAppointmentCollection ();

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

					shiftList.ItemTemplate = new DataTemplate(typeof(ShiftCalendarCell));
				}

				calendar.DataSource = shiftCollection;
			} catch (Exception e) {

			}


		}
	}
}

