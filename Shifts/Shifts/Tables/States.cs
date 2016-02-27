using System;
using SQLite;

namespace Shifts
{
	[Table("States")]
	public class States
	{
		[Unique]
		public string code { get; set; }

		public string name { get; set; }
	}
}

