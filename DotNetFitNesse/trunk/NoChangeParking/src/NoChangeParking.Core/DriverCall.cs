using System;
using System.Collections.Generic;
using System.Text;

namespace NoChangeParking.Core {
	public class DriverCall {
		private CallCentre _callCentre;
		private Driver _driver;
		private string _vehicle;
		private string _creditCard;
        private CallState _state;

		public DriverCall(CallCentre callCentre,Driver driver) {
			_callCentre = callCentre;
			_driver = driver;
			_vehicle = string.Empty;
			_creditCard = string.Empty;
            _state = CallState.EnterDetails;
			if (DriverIsRegistered) {
				SetRegisteredDetails();
            }
		}

		public bool DriverIsRegistered {
			get {
				return _driver.HasRegistered;
			}
		}

		private void SetRegisteredDetails() {
			_vehicle = _driver.DefaultVehicle;
			_creditCard = _driver.DefaultCreditCard;
			_state = CallState.OfferDefaultDetails;
		}

		public Driver Driver {
			get { return _driver; }
		}

		public string Vehicle {
			get { return _vehicle; }
		}

		public string CreditCard {
			get { return _creditCard; }
		}

		public Voucher PayForVehicleWithCreditCard(string vehicle, string creditCardNumber) {
			return PayForVehicleWithCreditCardForDays(vehicle, creditCardNumber, 1);
		}


		public Voucher PayForVehicleWithCreditCardForDays( string vehicle, string creditCardNumber, int days ) {
			return _callCentre.PayForVehicleWithCreditCardForDays(vehicle, creditCardNumber, days);
		}

		public Voucher PayParkingForDays(int days) {
			return PayForVehicleWithCreditCardForDays(Vehicle, CreditCard, days);
		}

		public Voucher PayParkingForToday() {
			return PayParkingForDays(1);
		}

		public bool RegisterVehicle( string vehicle ) {
			_driver.RegisterVehicle(vehicle);
			if (DriverIsRegistered)
				SetRegisteredDetails();
			return true;
		}

		public bool RegisterCreditCard( string ccNo ) {
			_driver.RegisterCard(ccNo);
			if (DriverIsRegistered)
				SetRegisteredDetails();
			return true;
		}

		public string PromptMessage {
            get {
                switch (_state) {
                    case CallState.OfferDefaultDetails:
						return string.Format("Do you wish to pay for {0} using Credit Card {1}?", _driver.DefaultVehicle, _driver.DefaultCreditCard);
					default:
						return "Enter your Vehicle registration and Credit Card number";
                }
            }
		}

        public bool SelectDefaults(bool selected)
        {
            SelectDefaultVehicle(selected);
            SelectDefaultCreditCard(selected);
			if (!selected)
				_state = CallState.EnterDetails;
            return true;
        }

        public bool SelectDefaultVehicle(bool selected)
        {
			if(selected) {
				_vehicle = _driver.DefaultVehicle;
			} else {
				_vehicle = string.Empty;
			}
			return true;
		}

		public bool SelectDefaultCreditCard( bool selected ) {
			if(selected) {
				_creditCard = _driver.DefaultCreditCard;
			} else {
				_creditCard = string.Empty;
			}
			return true;
		}

        public enum CallState
        {
            EnterDetails,
            OfferDefaultDetails
        }
	
	}

 
}
