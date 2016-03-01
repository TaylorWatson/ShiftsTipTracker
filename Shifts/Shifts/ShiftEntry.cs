using System;

using Xamarin.Forms;
using System.Diagnostics;
using SQLite;
using System.Collections.Generic;

namespace Shifts
{
	public class ShiftEntry : ContentPage
	{
		public Shift shift;

		public ShiftEntry ()
		{
			shift = new Shift ();
			DatePicker startDate = new DatePicker(); startDate.DateSelected += StartDate_DateSelected;
			DatePicker endDate = new DatePicker (); endDate.DateSelected += EndDate_DateSelected;
			Entry title = new Entry { Placeholder = "Shift Title", ClassId = "title" }; title.TextChanged += Title_TextChanged;
			Entry location = new Entry { Placeholder = "Location" }; location.TextChanged += Location_TextChanged;
			Button save = new Button () { Text = "Save" }; save.Clicked += Save_Clicked;


			startDate.DateSelected += (object sender, DateChangedEventArgs e) => {
				Debug.WriteLine("Poop");
			};

			Content = new StackLayout {
				Padding = new Thickness(20, 20, 20, 20),
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					title,
					location,
					startDate,
					endDate,
					save
				}
			};

		}

		async private void Save_Clicked (object sender, EventArgs e)
		{


			SQLiteConnection db = (SQLiteConnection) DependencyService.Get<ISQLite> ().GetConnection ();
			int result = db.Insert (shift);

			await Navigation.PopAsync ();
		}

		void Location_TextChanged (object sender, TextChangedEventArgs e)
		{
			shift.shiftLocation = e.NewTextValue;
		}

		void Title_TextChanged (object sender, TextChangedEventArgs e)
		{
			shift.shiftTitle = e.NewTextValue;
		}

		void EndDate_DateSelected (object sender, DateChangedEventArgs e)
		{
			Debug.WriteLine (e);
			Debug.WriteLine ("End changed");
			shift.endTime = e.NewDate;
		}

		void StartDate_DateSelected (object sender, DateChangedEventArgs e)
		{
			Debug.WriteLine (e);
			Debug.WriteLine ("Start changed");
			shift.startTime = e.NewDate;
		}
	}
}


