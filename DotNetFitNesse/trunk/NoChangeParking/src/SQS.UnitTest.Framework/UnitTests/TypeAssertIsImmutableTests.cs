using NUnit.Framework;

namespace SQS.UnitTest.Framework.UnitTests
{

	[TestFixture]
	public class TypeAssertIsImmutableTests
	{
		[Test]
		public void CanTestIsImmutable()
		{
			TypeAssert.IsImmutable(typeof (ImmutableStruct));
		}
		[Test]
		[ExpectedException(typeof(AssertionException),ExpectedMessage = "Expected MutableStruct to be immutable: field _age is not read-only")]
		public void IsImmutableFailsIfTypeHasANonReadonlyField()
		{
			TypeAssert.IsImmutable((typeof(MutableStruct)));
		}
	}
}


