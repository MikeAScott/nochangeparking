using System;
using fit;
using NoChangeParking.Core;

namespace NoChangeParking.FitFixtures
{
    public class CheckApplication: ColumnFixture{
        public string Name() {
            return ApplicationInfo.ApplicationName;
        }
    }
}


