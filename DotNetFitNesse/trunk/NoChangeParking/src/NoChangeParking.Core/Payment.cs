using System;

namespace NoChangeParking.Core
{
	public class Payment
	{
		private string vehicle;
		private Money amount;
		
		internal Payment(string vehicle, Money amount) 
		{
			this.vehicle = vehicle;
			this.amount = amount;
		}
		
		public string PaidForVehicle 
		{
			get { return vehicle; }
		}

		public override bool Equals(object obj) 
		{
			return (obj.GetType() == typeof(Payment)) &&
				   ((Payment)obj).vehicle == this.vehicle;
		}

		public override int GetHashCode() 
		{
			return vehicle.GetHashCode();
		}

		public Money Amount {
			get { return amount; }
		}
	}
}
