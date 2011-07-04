using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NoChangeParking.Core
{
	public class PaymentsList:ReadOnlyCollection<Payment>
	{
		public PaymentsList():base(new List<Payment>()){/*NOOP*/}

/*		public Payment AddPayment(string vehicle, int days, Money amount) {
			if (HasPaid(vehicle)) return null;
			Payment thePayment = new Payment(vehicle, days, amount);
			Items.Add(thePayment);
			return thePayment;
		}
*/
		public bool HasPaid(string vehicle) {
			return Contains(new Payment(vehicle,null)); 
		}

		internal Payment Add(Payment payment) {
			Items.Add(payment);
			return payment;
		}
	}
}
