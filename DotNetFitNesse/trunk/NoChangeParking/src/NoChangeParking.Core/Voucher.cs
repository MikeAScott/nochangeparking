using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoChangeParking.Core {
	public class Voucher {

		private string vehicle;
		private Money price;
		private int days;
		private DateTime expiry;

		public Voucher(string vehicle, Money price, int days, DateTime expiry) {
			this.vehicle = vehicle;
			this.price = price;
			this.days = days;
			this.expiry = expiry;
		}

		public string Vehicle {
			get { return vehicle; }
		}

		public int PaidForDays {
			get {
				return days;
			}
		}
		public Money Price {
			get { return price; }
		}

		public DateTime Expiry {
			get { return expiry; }
		}


	}
}
