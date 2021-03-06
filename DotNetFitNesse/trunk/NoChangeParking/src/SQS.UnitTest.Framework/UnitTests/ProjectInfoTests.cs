using NUnit.Framework;
using SQS.UnitTest.Framework;

namespace SQS.UnitTest.Framework.UnitTests
{
	[TestFixture]
	public class ProjectInfoTests
	{
		private readonly string PROJECT_NAME = "SQS.UnitTest.Framework";
		[Test]
		public void TestProjectName()
		{
			Assert.AreEqual(PROJECT_NAME, ProjectInfo.ProjectName);
		}
		[Test]
		public void ProjectInfoCantBeInstantiatied()
		{
			TypeAssert.HasNoPublicConstructors(typeof(ProjectInfo));
			TypeAssert.HasPrivateParameterlessConstructor(typeof(ProjectInfo));
		}
	}
}



