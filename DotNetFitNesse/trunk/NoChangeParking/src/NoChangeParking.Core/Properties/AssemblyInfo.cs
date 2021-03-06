using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("NoChangeParking Core")]
[assembly: AssemblyDescription("NoChangeParking Core Logic")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCulture("")]		

//
// Company and Product information is in SolutionInfo.cs
//

#if DEBUG
	[assembly: InternalsVisibleTo("NoChangeParking.Core.UnitTests")]
	[assembly: InternalsVisibleTo("NoChangeParking.FitFixtures")]
#endif

[assembly: SecurityPermission(SecurityAction.RequestMinimum)] 
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]		

//
// Version information is in VersionInfo.cs
//

//
// Signing information is in SolutionInfo.cs
//




