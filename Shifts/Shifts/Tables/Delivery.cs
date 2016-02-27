using System;
using SQLite;

namespace Shifts
{
	[Table("Delivery")]
	public class Delivery
	{
		[PrimaryKey, AutoIncrement]
		public int deliveryId { get; set; }
		public int deliveryNumber { get; set; }

		public int paymentOption { get; set; }
		public bool isOut { get; set; }
		public int shiftId { get; set; }
	}
}

