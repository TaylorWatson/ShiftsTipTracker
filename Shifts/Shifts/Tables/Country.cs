using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace Shifts
{
	[Table("Country")]
	public class Country
	{
		[Unique]
		public string code { get; set; }
		public string name { get; set; }
	}
}

