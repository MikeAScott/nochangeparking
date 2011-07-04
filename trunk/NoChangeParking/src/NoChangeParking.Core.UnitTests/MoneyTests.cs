using System;
using NUnit.Framework;
using NoChangeParking.Core;

namespace NoChangeParking.Core.UnitTests
{
	[TestFixture]
	public class MoneyTests {
		[Test]
		public void CanCreateWithCurrencyAndAmount() {
			Assert.IsNotNull(new Money("GBP", 50));
		}

		[Test]
		public void AmountIsSetCorrectly() {
			var m = new Money("GBP", 5.00m);
			Assert.AreEqual(5.00d,m.Amount);
		}

		[Test]
		public void ParseUsesCurrencySymbol() {
			var m = Money.Parse("£6.56");
			Assert.AreEqual(6.56m, m.Amount);
			Assert.AreEqual("GBP", m.Currency);
		}

		[Test]
		public void CanParseDollars() {
			var m = Money.Parse("$5.32");
			Assert.AreEqual(5.32m, m.Amount);
			Assert.AreEqual("USD", m.Currency);
		}

		[Test]
		public void ToStringFormatsWithCurrencySymbol() {
			var m = new Money("GBP",3.45m);
			Assert.AreEqual("£3.45",m.ToString());
		}
		
		[Test]
		public void MoneyIsEqualIfCurrencyAndAmountAreEqual() {
			var m = new Money("GBP", 4.56m);
			Assert.AreEqual(new Money("GBP",4.56m), m);
		}

		[Test]
		public void MoneyIsNotEqualIfCurrencyIsEqualButAmountIsNot() {
			var m = new Money("USD", 5.78m);
			Assert.AreNotEqual(new Money("USD",5.79m), m);
		}

		[Test]
		public void MoneyIsNotEqualIfCurrencyIsNotEqualButAmountIsEqual() {
			var m = new Money("USD", 5.78m);
			Assert.AreNotEqual(new Money("CAD",5.78m), m);
		}

		[Test]
		public void MoneyIsNotEqualIfCurrencyAndAmountAreNotEqual() {
			var m = new Money("USD", 5.70m);
			Assert.AreNotEqual(new Money("CAD",5.70m), m);
		}
		
		[Test]
		public void FivePoundsTimesOneIsFivePounds() {
			var m = new Money("GBP",5.00m);
			Assert.AreEqual(new Money("GBP",5.00m), m.Times(1));
		}

		[Test]
		public void FivePoundsTimesTwoIsTenPounds() {
			var m = new Money("GBP",5.00m);
			Assert.AreEqual(new Money("GBP",10.00m), m.Times(2));
		}
		
		[Test]
		public void MoneyEqualsHandlesNull() {
			var m = new Money("GBP", 3.47m);
			Assert.IsFalse(m.Equals(null));
		}
		
		[Test]
		public void MoneyEqualsHandlesNonMoneyObjects() {
			var m = new Money("GBP", 3.49m);
			Assert.IsFalse(m.Equals(new Object()));
		}
	}
}
