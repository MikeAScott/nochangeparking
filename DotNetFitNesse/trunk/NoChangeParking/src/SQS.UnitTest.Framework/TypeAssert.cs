using System;
using System.Globalization;
using NUnit.Framework;
using System.Reflection;

namespace SQS.UnitTest.Framework
{
	public class TypeAssert : Assert
	{
		private const string EXPECTED_NO_PUBLIC_CTORS = "Expected {0} to have no public constructors but it has {1}";
		private const string EXPECTED_PRIVATE_PARAMETERLESS_CTOR = "Expected {0} to have a private parameterless constructor";
		private const string IS_NOT_VALUE_TYPE = "Expected {0} to be a value type";
		private const string IS_NOT_SEALED = "Expected {0} to be sealed";
		private const string IS_NOT_IMMUTABLE = "Expected {0} to be immutable: field {1} is not read-only";

		readonly Type _type;
		
		private TypeAssert(Type type)
		{
			_type = type;
		}

		public static void HasNoPublicConstructors(Type type)
		{
			TypeAssert assert = new TypeAssert(type);
			assert.HasNoPublicConstructors();
		}

		public static void HasPrivateParameterlessConstructor(Type type)
		{
			TypeAssert assert = new TypeAssert(type);
			assert.HasPrivateParameterlessConstructor();
		}

		public static void IsValueType(Type type)
		{
			TypeAssert assert = new TypeAssert(type);
			assert.IsValueType();
		}

		public static void IsSealed(Type type)
		{
			TypeAssert assert = new TypeAssert(type);
			assert.IsSealed();
		}

		public static void IsImmutable(Type type)
		{
			TypeAssert assert = new TypeAssert(type);
			assert.IsImmutable();
		}

		private void AssertFails(string message, params object[] args)
		{
			object[] messageArgs = new object[args.Length + 1];
			messageArgs[0] = _type.Name;
			for (int i = 0; i < args.Length; i++)
			{
				messageArgs[i + 1] = args[0];
			}
			Fail(string.Format(CultureInfo.CurrentCulture, message, messageArgs));
		}

		protected void IsValueType()
		{
			if(!_type.IsValueType)
			{
				AssertFails(IS_NOT_VALUE_TYPE);
			}
		}

		protected void HasNoPublicConstructors()
		{
			MemberInfo[] ctors = _type.GetConstructors();
			if (ctors.Length > 0)
			{
				AssertFails(EXPECTED_NO_PUBLIC_CTORS,ctors.Length);
			}
		}

		protected void HasPrivateParameterlessConstructor()
		{
			try
			{
				_type.InvokeMember(_type.Name,
				                   BindingFlags.CreateInstance | BindingFlags.Instance | BindingFlags.NonPublic,
				                   null, null, null,CultureInfo.InvariantCulture);
			}
			catch (MissingMethodException)
			{
				AssertFails(EXPECTED_PRIVATE_PARAMETERLESS_CTOR);
			}
		}


		private void IsSealed()
		{
			if (!_type.IsSealed)
			{
				AssertFails(IS_NOT_SEALED);
			}
		}

		private void IsImmutable()
		{
			FieldInfo[] fields = _type.GetFields(BindingFlags.NonPublic|BindingFlags.Instance);
			foreach (FieldInfo field in fields)
			{
				if (!field.IsInitOnly)
				{
					AssertFails(IS_NOT_IMMUTABLE, field.Name);
				}
			}
		}
	}
}


