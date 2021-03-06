using NUnit.Framework;

namespace SQS.UnitTest.Framework.UnitTests
{
	/// <summary>
	/// This Tests that this assembly is set up correctly
	/// and also indirectly tests the AssemblyTestBase class
	/// </summary>
	[TestFixture]
	public class AssemblyAssertTests
	{
		private readonly string UNIT_TEST_FRAMEWORK_ASSEMBLY_NAME = "SQS.UnitTest.Framework";
		private readonly string NON_EXISTENT_ASSEMBLY_NAME = "Assembly.That.Does.Not.Exist";
		private readonly string EXPECTED_FAIL_PREFIX_MSG = "Namespace Error in Class:";
		private readonly string EXPECTED_FAIL_CONTAINS_MSG = "Expected: Namespace starting with 'bad.prefix', But was:'SQS.UnitTest.Framework";

		[Test]
		public void AssemblyNameIsCorrect()
		{
			AssemblyAssert.CanLoad(UNIT_TEST_FRAMEWORK_ASSEMBLY_NAME);
		}

		[Test]
		public void AllTypeNamespacesAreCorrectlyPrefixed()
		{
			AssemblyAssert.TypeNamespacesPrefix(UNIT_TEST_FRAMEWORK_ASSEMBLY_NAME);
		}

		[Test, ExpectedException(typeof(AssertionException))]
		public void AssertionFailsIfAssemblyNotLoaded()
		{
			AssemblyAssert.CanLoad(NON_EXISTENT_ASSEMBLY_NAME);
		}

		[Test]
		public void TypeNamespacesAssertCanUseDifferentPrefix()
		{
			AssemblyAssert.TypeNamespacesPrefix(UNIT_TEST_FRAMEWORK_ASSEMBLY_NAME, "SQS");
		}

		[Test]
		// Can't use ExpectedException here because type reported in failure message may change
		public void AssertionFailsIfNamespacesAreNotCorrectlyPrefixed()
		{
			bool assertionFailed = false;
			try
			{
				AssemblyAssert.TypeNamespacesPrefix(UNIT_TEST_FRAMEWORK_ASSEMBLY_NAME, "bad.prefix");
			}
			catch (AssertionException ex)
			{
				assertionFailed = true;
				StringAssert.StartsWith(EXPECTED_FAIL_PREFIX_MSG, ex.Message);
				StringAssert.Contains(EXPECTED_FAIL_CONTAINS_MSG, ex.Message);
			}
			AssemblyAssert.IsTrue(assertionFailed, "Expected Assert.TypeNamespacesPrefix to fail");
		}
	}
}


