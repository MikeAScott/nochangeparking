using System;
using System.Collections.Generic;
using System.Text;

namespace NoChangeParking.Core {
	public class ParkingLocation {
		private int _id;
		private string _name;

		public ParkingLocation( int id, string name, decimal parkingrate ) {
			_id = id;
			_name = name;
			_parkingRate = parkingrate;
		}
		
		public ParkingLocation(int id, string name):this(id,name,2.00m) {
		}

		public int Id {
			get { return _id; }
		}

		public string Name {
			get { return _name; }
		}

		private decimal _parkingRate;				
		public decimal ParkingRate {
			get { return _parkingRate; }
		}
	
	
	}
}
