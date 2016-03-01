﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.SfSchedule.XForms;
using System.Diagnostics;

namespace Shifts
{
	public class CalendarOverviewPage : ContentPage
	{

		public CalendarOverviewPage ()
		{
			Title = "Overview";

			var btnAdd = new ToolbarItem {
				Text = "Add",

			};
			btnAdd.Clicked += async (object sender, EventArgs e) => Navigation.PushAsync(new ShiftEntry());
			this.ToolbarItems.Add (btnAdd);


			//add layout type
			StackLayout layout = new StackLayout ();

			SfSchedule calendar = new SfSchedule ();
			calendar.ScheduleView = ScheduleView.MonthView;
			calendar.ShowAppointmentsInline = false;

			DateTime currentDate = DateTime.Now;

			calendar.HorizontalOptions = LayoutOptions.FillAndExpand;
			calendar.HeightRequest = 400;

			layout.Children.Add (calendar);

			Content = layout;

		}
	}
}

