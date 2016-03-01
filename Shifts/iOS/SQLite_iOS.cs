using System;
using System.Runtime.CompilerServices;
using SQLite;
using System.IO;

namespace Shifts.iOS
{
	[assembly: Dependency (typeof (SQLite_iOS))]
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS ()
		{
			
		}

		public SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "Shifts.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
			var path = Path.Combine(libraryPath, sqliteFilename);
			// Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;
		}
	}
}

