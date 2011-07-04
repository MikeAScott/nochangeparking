using System;
using System.Collections.Generic;
using System.Text;
using fitlibrary;
using NoChangeParking.Core;

namespace NoChangeParking.FitFixtures {
	public class SetupRegisteredDriversFixture:SetUpFixture {

		public SetupRegisteredDriversFixture() {
			CallCentre.Instance.ClearRegisteredDrivers();
		}

		public bool DriverDefaultVehicleDefaultCreditCard( string driver, string vehice, string creditCard ) {
			DriverCall call = CallCentre.Instance.NewCallFromDriver(driver);
			call.RegisterVehicle(vehice);
			call.RegisterCreditCard(creditCard);
			return true;
		}
	}

 }
