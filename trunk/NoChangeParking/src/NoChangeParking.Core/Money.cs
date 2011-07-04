using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoChangeParking.Core {
	public class Money {

		private string currency;

		private decimal amount;

		public Money(string currency, decimal amount) {
			this.amount = amount;
			this.currency = currency;
		}

		public string Currency {
			get { return currency; }
			set { currency = value; }
		}

		public decimal Amount {
			get {
				return amount;
			}
		}

		public Money Times(int times) {
			return new Money(this.currency, this.amount * times);
		}

		public static Money Parse(string rep) {
			string symbol = rep.Substring(0, 1);
			string currency = "$".Equals(symbol) ? "USD" : "GBP";
			decimal amount = Decimal.Parse(rep.Substring(1));
			return new Money(currency, amount);
		}

		public override string ToString() {
			return "£" + amount.ToString("G");
		}

		public override bool Equals(object obj) {
			if (obj == null ||
				obj.GetType() != typeof(Money) )
				return false;
			Money m = (Money)obj;
			return (m.amount == this.amount && 
					m.currency == this.currency);
		}
	}
}
