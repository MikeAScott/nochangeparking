using System;

namespace NoChangeParking.Core
{
    /// <summary>
    /// Contains information about the application.
    /// Set up as a skeleton class to check that the UnitTest and FitFixtures references are wired up properly
    /// </summary>
    public sealed class ApplicationInfo{
		private ApplicationInfo() {}
		public static string ApplicationName{
			get { return "NoChangeParking"; }
		}
    }
}


