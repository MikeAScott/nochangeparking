using System;
using System.Collections.Generic;
using System.Text;

namespace NoChangeParking.Core {
	public class CallCentre {

		private static CallCentre _instance;
		private PaymentsList _todaysPayments;
		private ParkingChargeCalculator _chargeCalculator;

		private Dictionary<string, Driver> _drivers;

		private CallCentre(Money dailyRate) {
			_chargeCalculator = new ParkingChargeCalculator(dailyRate);
			ClearRegisteredDrivers();
		}

		public static CallCentre Instance {
			get {
				if(_instance == null)
					_instance = new CallCentre(new Money("GBP",5));
				return _instance;
			}
		}

		public DriverCall NewCallFromDriver( string name ) {
			if (_drivers.ContainsKey(name)) {
				return new DriverCall(this,_drivers[name]);
			} else {
				Driver newDriver = new Driver(name);
				_drivers.Add(name, newDriver);
				return new DriverCall(this, newDriver);
			}
		}

		internal Voucher PayForVehicleWithCreditCardForDays( string vehicle, string creditCardNumber, int days ) {
			if(TodaysPayments.HasPaid(vehicle))
				return null;
			Money price = _chargeCalculator.PriceForDays(days);
			Voucher ticket = IssueTicket(vehicle, days, price);
			Payment payment = new Payment(vehicle, ticket.Price);
			TodaysPayments.Add(payment);
			return ticket;
		}

		private static Voucher IssueTicket(string vehicle, int duration, Money price) {
			var expiry = CalculateExpiry(duration);
			return new Voucher(vehicle, price, duration, expiry);
		}

		internal static DateTime CalculateExpiry(int duration) {
			var expiry = (SystemClock.Now.Date.AddDays(duration).Subtract(new TimeSpan(0,0,1)));
			return expiry;
		}


        public ICollection<Driver> RegisteredDrivers {
            get {
                return _drivers.Values;
            }
        }
        public PaymentsList TodaysPayments
        {
			get {
				if (_todaysPayments == null)
					_todaysPayments = new PaymentsList(); ;
				return _todaysPayments;
			}
		}

		public bool VehicleHasPaid( string vehicle ) {
			return TodaysPayments.HasPaid(vehicle);
		}

		public bool VehicleHasNotPaid( string vehicle ) {
			return !VehicleHasPaid(vehicle);
		}

		internal void ClearRegisteredDrivers() {
			_drivers = new Dictionary<string, Driver>();
		}

		internal void ClearTodaysPayments() {
			_todaysPayments = new PaymentsList();
		}
	}
}
