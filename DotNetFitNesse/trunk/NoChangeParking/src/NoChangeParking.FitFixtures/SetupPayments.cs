using System;
using fitlibrary;
using NoChangeParking.Core;

namespace NoChangeParking.FitFixtures
{
	public class SetupPayments: SetUpFixture
	{
		public SetupPayments()
		: base() {
			CallCentre.Instance.ClearTodaysPayments();
		}

		public void Vehicle(string name) {
			CallCentre.Instance.TodaysPayments.Add(new Payment(name, null));
		}
	}
}
