namespace SQS.UnitTest.Framework
{
    /// <summary>
    /// Contains information about the application.
    /// Set up as a skeleton class to check that the UnitTest and 
    /// FitFixtures references are wired up properly
    /// </summary>
    internal sealed class ProjectInfo
    {
		private ProjectInfo() {}
		
		public static string ProjectName
		{
			get { return "SQS.UnitTest.Framework"; }
		}
    }
}



