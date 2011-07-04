using System;
using System.Collections.Generic;
using fitlibrary;

namespace NoChangeParking.FitFixtures {
	public class CalendarFixture : SetUpFixture {

		private Dictionary<string, DateTime> calendar = new Dictionary<string, DateTime>();

		public void DayDate(string day, DateTime date) {
			calendar.Add(day, date);
		}

		public DateTime Lookup(String day) {
			return calendar[day];
		}

		internal string Lookup(DateTime date) {
			Dictionary<String,DateTime>.Enumerator enumer = calendar.GetEnumerator();
			while (enumer.MoveNext()) {
				if (date.Date == enumer.Current.Value)
					return enumer.Current.Key;
			}
			return null;
		}
	}
}
