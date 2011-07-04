using System;
using System.Collections.Generic;
using System.Text;
using NoChangeParking.Core;
using fit;
using fitlibrary;

namespace NoChangeParking.FitFixtures {
    public class TheCallCentreFixture:DoFixture {
		public TheCallCentreFixture() {
			mySystemUnderTest = CallCentre.Instance;
		}

		public Fixture TodaysPayments() {
			return new SetFixture(CallCentre.Instance.TodaysPayments);
		}

		private CalendarFixture myCalendar;
		public Fixture SetupCalendar() {
			myCalendar = new CalendarFixture();
			return myCalendar;
		}

		public Fixture CheckParkingValidityFor(string time) {
			DateTime inspectionTime = myCalendar.Lookup(time);
			return new CheckExpiryFixture(myCalendar, inspectionTime);
		}
	}

}
