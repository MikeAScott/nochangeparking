using NUnit.Framework;
namespace SQS.UnitTest.Framework.UnitTests
{
	[TestFixture]
	public class ValueTypeAssertTests
	{

		[Test]
		public void CanTestForValueType()
		{
			TypeAssert.IsValueType(typeof (SimpleStruct));
		}

		[Test]
		[ExpectedException(typeof(AssertionException),ExpectedMessage = "Expected SimpleClass to be a value type")]
		public void IsValueTypeFailsIfNotAValueType()
		{
			TypeAssert.IsValueType(typeof(SimpleClass));	
		}

		[Test]
		public void CanTestForValueTypeOnIntTypes()
		{
			TypeAssert.IsValueType(typeof(int));
		}

		[Test]
		[ExpectedException(typeof(AssertionException), ExpectedMessage = "Expected String to be a value type")]
		public void CanTellStringIsNotAValueType()
		{
			TypeAssert.IsValueType(typeof(string));	
		}

		[Test]
		public void CanTellEnumsAreValueTypes()
		{
			TypeAssert.IsValueType(typeof(SimpleEnum));
		}

		[Test]
		public void CanTestForSealedClasses()
		{
			TypeAssert.IsSealed(typeof (SealedClass));
		}

		[Test]
		public void CanTestValueTypesAreSealed()
		{
			TypeAssert.IsSealed(typeof(SimpleStruct));
		}

		[Test]
		[ExpectedException(typeof(AssertionException),ExpectedMessage = "Expected SimpleClass to be sealed")]
		public void IsSealedFailsIfNotSealed()
		{
			TypeAssert.IsSealed(typeof(SimpleClass));
		}
	}
}


