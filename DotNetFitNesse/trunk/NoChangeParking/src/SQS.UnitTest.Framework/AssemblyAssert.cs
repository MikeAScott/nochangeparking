using System;
using System.Globalization;
using System.Reflection;
using System.IO;
using NUnit.Framework;

namespace SQS.UnitTest.Framework
{
	public class AssemblyAssert : Assert
	{
		private const string STARTS_WITH_EXCEPTION = "Namespace Error in Class: '{0}'. Expected: Namespace starting with '{1}', But was:'{2}'";
		private const string CANT_LOAD_ASSEMBLY_MESSAGE = "Can't load assembly {0}";

		private readonly string _assemblyPath;
		private Assembly _testAssembly;

		private AssemblyAssert(Assembly callingAssembly, string assemblyName)
		{
			_assemblyPath = GetAssemblyPath(callingAssembly, assemblyName);
		}
		
		public static void CanLoad(string assemblyName)
		{
			//NB: Must call Assembly.GetCallingAssembly() here to report correct caller
			AssemblyAssert assert = new AssemblyAssert(Assembly.GetCallingAssembly(), assemblyName);
			assert.AssertLoad();
		}

		public static void TypeNamespacesPrefix(string assemblyName, string namespacePrefix)
		{
			//NB: Must call Assembly.GetCallingAssembly() here to report correct caller
			AssemblyAssert assert = new AssemblyAssert(Assembly.GetCallingAssembly(), assemblyName);
			assert.AssertLoad();
			assert.AssertTypePrefixesAre(namespacePrefix);
		}

		public static void TypeNamespacesPrefix(string assemblyName)
		{
			//NB: Must call Assembly.GetCallingAssembly() here to report correct caller
			AssemblyAssert assert = new AssemblyAssert(Assembly.GetCallingAssembly(), assemblyName);
			assert.AssertLoad();
			assert.AssertTypePrefixesAre(assemblyName);
		}

		protected Assembly AssertLoad()
		{
			try
			{
				_testAssembly = Assembly.LoadFrom(_assemblyPath);
			}
			catch (FileNotFoundException ex)
			{
				Fail(String.Format(CultureInfo.CurrentCulture, CANT_LOAD_ASSEMBLY_MESSAGE, ex.FileName));
			}

			return _testAssembly;
		}
		
		protected void AssertTypePrefixesAre(string namespacePrefix)
		{
			foreach (Type aType in _testAssembly.GetTypes())
			{
				if (aType.Name != typeof(CoverageExcludeAttribute).Name &&
					!aType.Namespace.StartsWith(namespacePrefix,StringComparison.CurrentCulture)
					)
				{
					throw new AssertionException(String.Format(CultureInfo.CurrentCulture, STARTS_WITH_EXCEPTION, aType.Name, namespacePrefix, aType.Namespace));
				}
			}
		}

		private static string GetAssemblyPath(Assembly callingAssembly, string assemblyName)
		{
			return Path.GetDirectoryName(callingAssembly.CodeBase.Replace(@"file:///", "")) + "\\" + assemblyName + ".dll";
		}
	}
}


