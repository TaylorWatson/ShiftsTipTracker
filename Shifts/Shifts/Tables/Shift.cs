using System;
using SQLite;

namespace Shifts
{
	[Table("Shift")]
	public class Shift
	{
		[PrimaryKey, AutoIncrement]
		public int shiftId { get; set; }

		public DateTimeOffset startTime { get; set; }
		public DateTimeOffset endTime { get; set; }

		public double hourlyIncome { get; set; }
		public double deliveryBonus { get; set; }
		public double outBonus { get; set; }
		public double debitFee { get; set; }
	}
}

