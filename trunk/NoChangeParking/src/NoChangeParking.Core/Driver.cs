using System;

namespace NoChangeParking.Core
{
	public class Driver
	{
		public Driver(string id) {
			_id = id;
			_defaultCreditCard = string.Empty;
			_defaultVehicle = string.Empty;
		}

        private string _id;
        public string Id
        {
            get { return _id; }
        }

		private string _defaultVehicle;
		public string DefaultVehicle {
			get { return _defaultVehicle; }
		}

		private string _defaultCreditCard;
		public string DefaultCreditCard {
			get { return _defaultCreditCard; }
		}

		public bool RegisterVehicle(string vehicle) {
			_defaultVehicle = vehicle;
 			return true;
		}

		public bool RegisterCard(string ccNo) {
			_defaultCreditCard = ccNo;
            return true;
		}
        public bool HasRegistered
        {
            get { return !String.IsNullOrEmpty(_defaultCreditCard) 
                      && !String.IsNullOrEmpty(_defaultVehicle); 
            }
        }

	}
}
