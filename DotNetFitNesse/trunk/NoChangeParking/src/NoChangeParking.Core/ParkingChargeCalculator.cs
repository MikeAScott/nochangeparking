using System;

namespace NoChangeParking.Core {
    public class ParkingChargeCalculator {

		private Money dailyRate;

		public ParkingChargeCalculator(Money dailyRate) {
			this.dailyRate = dailyRate;
		}


		internal Money PriceForDays(int duration) {
			if (duration > 7)
				throw new ArgumentException("Too many days");
			return dailyRate.Times(duration);
		}

	}
}
