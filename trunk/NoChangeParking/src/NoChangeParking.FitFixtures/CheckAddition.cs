using System;
using fit;

namespace NoChangeParking.FitFixtures
{
	public class CheckAddition: ColumnFixture
	{
		public int lhs;
		public int rhs;
		
		public int result() {
			NoChangeParking.Core.Calculator testAddition = new NoChangeParking.Core.Calculator();
			return testAddition.Add(lhs,rhs);
		}
	}
}
