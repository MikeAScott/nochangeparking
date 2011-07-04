using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoChangeParking.Core {
	public static class SystemClock {

		private static DateTime? frozenTime=null; 
		public static DateTime Now {
			get {
				if (frozenTime == null)
					return DateTime.Now;
				else
					return frozenTime.Value;
			}
		}

		internal static void SetNow(DateTime dateTime) {
			frozenTime = dateTime;
		}

		internal static void Reset() {
			frozenTime = null;
		}
	}
}
