namespace SQS.UnitTest.Framework.UnitTests
{
	[CoverageExclude]
	struct SimpleStruct{}

	[CoverageExclude]
	enum SimpleEnum{}

	[CoverageExclude]
	class SimpleClass{}

	[CoverageExclude]
	sealed class SealedClass{}

	[CoverageExclude]
	class SimpleClassWithPrivateConstructor
	{
		private SimpleClassWithPrivateConstructor() {/*NOOP*/}
	}

	[CoverageExclude]
	class SimpleClassWithPublicConstructors
	{
		private readonly string _name;
		private readonly bool _isOK;

		public SimpleClassWithPublicConstructors(string name) : this(name, true){}

		public SimpleClassWithPublicConstructors(string name, bool isOK)
		{
			_name = name;
			_isOK = isOK;
		}

		public string GetNameIfOK()
		{
			return _isOK ? _name : string.Empty;
		}
	}

	[CoverageExclude]
	struct ImmutableStruct
	{
		private readonly string _name;
		public ImmutableStruct(string name)
		{
			_name = name;
		}

		public string Name
		{
			get { return _name; }
		}
	}

	[CoverageExclude]
	struct MutableStruct
	{
		private readonly string _name;
		private int _age;
		public MutableStruct(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public string Name
		{
			get { return _name; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value;}
		}
	}
}

