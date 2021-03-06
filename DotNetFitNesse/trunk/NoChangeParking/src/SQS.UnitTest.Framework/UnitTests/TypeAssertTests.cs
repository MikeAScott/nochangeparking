using System;
using NUnit.Framework;

namespace SQS.UnitTest.Framework.UnitTests
{
	[TestFixture]
	public class TypeAssertTests
	{

		[Test]
		public void TypeAssertIsTypeOfAssert()
		{
			Assert.AreEqual(typeof(Assert), typeof(TypeAssert).BaseType);
		}

		[Test]
		public void CanTestForNoPublicConstructors()
		{
			TypeAssert.HasNoPublicConstructors(typeof(SimpleClassWithPrivateConstructor));
		}

		[Test]
		[ExpectedException(typeof(AssertionException),ExpectedMessage="Expected SimpleClass to have no public constructors but it has 1")]
		public void TestForNoPublicConstructorFailsIfThereIsADefaultOne()
		{
			TypeAssert.HasNoPublicConstructors(typeof(SimpleClass));	
		}

		[Test]
		[ExpectedException(typeof(AssertionException), ExpectedMessage = "Expected SimpleClassWithPublicConstructors to have no public constructors but it has 2")]
		public void TestForNoPublicConstructorFailsIfThereAreDefinedOnes()
		{
			TypeAssert.HasNoPublicConstructors(typeof(SimpleClassWithPublicConstructors));
		}

		[Test]
		public void CanTestForPrivateParameterlessConstructor()
		{
			TypeAssert.HasPrivateParameterlessConstructor(typeof(SimpleClassWithPrivateConstructor));
		}

		[Test]
		[ExpectedException(typeof(AssertionException), ExpectedMessage = "Expected SimpleClass to have a private parameterless constructor")]
		public void TestForPrivateParameterlessConstructorFailsIfThereIsADefaultPublicOne()
		{
			TypeAssert.HasPrivateParameterlessConstructor(typeof (SimpleClass));
		}

		[Test]
		[ExpectedException(typeof(AssertionException), ExpectedMessage = "Expected SimpleClassWithPublicConstructors to have a private parameterless constructor")]
		public void TestForForPrivateParameterlessConstructorFailsIfThereAreDefinedPublicOnes()
		{
			TypeAssert.HasPrivateParameterlessConstructor(typeof(SimpleClassWithPublicConstructors));
		}

		[Test]
		public void TypeAssertHasNoPublicConstructors()
		{
			TypeAssert.HasNoPublicConstructors(typeof(TypeAssert));
		}
	}
}


