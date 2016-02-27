using System;
using SQLite;

namespace Shifts
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

