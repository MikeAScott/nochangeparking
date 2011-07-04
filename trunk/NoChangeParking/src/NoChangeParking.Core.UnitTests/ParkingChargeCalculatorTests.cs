using System;
using NUnit.Framework;

namespace NoChangeParking.Core.UnitTests
{
	[TestFixture]
	public class ParkingChargeCalculatorTests
	{
		private Money FIVE_POUNDS = new Money("GBP", 5.00m);
		private Money THREE_POUNDS_FIFTY = new Money("GBP", 3.50m);
		
		[Test]
		public void CanCreateACalculatorGivenDailyRate()
		{
			var calc = new ParkingChargeCalculator(FIVE_POUNDS);
			Assert.IsNotNull(calc);
		}

		[Test]
		public void ChargeForOneDayIs5WhenRateIs5() {
			var calc = new ParkingChargeCalculator(FIVE_POUNDS);
			Money price = calc.PriceForDays(1);
			Assert.AreEqual(new Money("GBP",5.00m) ,price);
		}
		
		[Test]
		public void ChargeForThreeDaysIs1050WhenRateIs350() {
			var calc = new ParkingChargeCalculator(THREE_POUNDS_FIFTY);
			Money price = calc.PriceForDays(3);
			Assert.AreEqual(new Money("GBP",10.50m) ,price);
		}

	}
}
