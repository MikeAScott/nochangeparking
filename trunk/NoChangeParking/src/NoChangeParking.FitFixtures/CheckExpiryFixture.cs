using System;
using System.Collections.Generic;
using System.Text;
using NoChangeParking.Core;
using fit;
using fitlibrary;

namespace NoChangeParking.FitFixtures {
	public class CheckExpiryFixture : ColumnFixture {

		private CalendarFixture myCalendar;
		private DateTime inspectionTime;

		public CheckExpiryFixture(CalendarFixture myCalendar, DateTime inspectionTime) {
			this.myCalendar = myCalendar;
			this.inspectionTime = inspectionTime;
		}

		public string DatePaid;
		public int paidForDays;

		public bool IsValid() {
			return (expiryDate >= SystemClock.Now);
		}

		public DateTime expiryDate;
		public DateTime paymentDate;


		public string Expiry() {
			return myCalendar.Lookup(expiryDate.Date);
		}

		public override void Execute() {
			base.Execute();
			paymentDate = myCalendar.Lookup(DatePaid);
			SystemClock.SetNow(paymentDate);
			expiryDate = CallCentre.CalculateExpiry(paidForDays);
			SystemClock.SetNow(inspectionTime);
		}

	}
}
