using System;
using SQLite;
using Xamarin.Forms;

namespace Shifts
{
	public class ShiftsDatabase
	{
		public SQLiteConnection database;

		public ShiftsDatabase ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
		}
	}
}

