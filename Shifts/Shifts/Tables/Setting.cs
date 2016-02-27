using System;
using SQLite;

namespace Shifts
{
	[Table("Setting")]
	public class Setting
	{
		[AutoIncrement, PrimaryKey]
		public int _id { get; set; }
		public int hourlyIncome { get; set; }
		public double deliveryBonus { get; set; }
		public double outBonus { get; set; }
		public double debitFee { get; set; }

		public string countryCode { get; set; }
		public string stateCode { get; set; }
	}
}

