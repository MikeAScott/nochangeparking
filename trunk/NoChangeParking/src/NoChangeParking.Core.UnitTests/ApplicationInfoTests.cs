using NUnit.Framework;
using NoChangeParking.Core;
using SQS.UnitTest.Framework;

namespace NoChangeParking.Core.UnitTests
{
	[TestFixture]
	public class ApplicationInfoTests
	{
		[Test]
		public void TestApplicationName()
		{
			Assert.AreEqual("NoChangeParking", ApplicationInfo.ApplicationName);
		}
		
		[Test]
		public void HasPrivateParameterlessContructor() {
			TypeAssert.HasPrivateParameterlessConstructor(typeof(ApplicationInfo));
		}

	}
}


