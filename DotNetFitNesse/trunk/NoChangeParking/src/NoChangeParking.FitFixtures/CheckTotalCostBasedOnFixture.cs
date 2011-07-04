using System;
using System.Collections.Generic;
using fit;
using NoChangeParking.Core;

namespace NoChangeParking.FitFixtures {
	public class CheckTotalCostBasedOnFixture: ColumnFixture {

		public int Duration;

		public Money PaymentAmount() {
			Money dailyRate = Money.Parse(Args[0]);
			var calc = new ParkingChargeCalculator(dailyRate);
			return calc.PriceForDays(Duration);
		}
	}


}
