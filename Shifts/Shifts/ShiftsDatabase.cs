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

		public void Initialize() 
		{
			try {
				if (database.Table<Shift> ().Count () != 0) {
					database.CreateTable<Shift> ();
				}
			}
			catch (Exception e) {
				database.CreateTable<Shift> ();
			}		
			try {
				if (database.Table<Delivery> ().Count () != 0) {
					database.CreateTable<Delivery> ();
				}
			}
			catch (Exception e) {
				database.CreateTable<Delivery> ();
			}		
			try {
				if (database.Table<Country> ().Count () != 0) {
					database.CreateTable<Country> ();
				}
			}
			catch (Exception e) {
				database.CreateTable<Country> ();
			}

			try {
				if (database.Table<States> ().Count () != 0) {
					database.CreateTable<States> ();
				}
			}
			catch (Exception e) {
				database.CreateTable<States> ();
			}		
			try {
				if (database.Table<Setting> ().Count () != 0) {
					database.CreateTable<Setting> ();
				}
			}
			catch (Exception e) {
				database.CreateTable<Setting> ();
			}
		}
	}
}

