using System;
using fit;

namespace NoChangeParking.FitFixtures
{
	public class CheckSayHello: ColumnFixture
	{
		public string name;
		NoChangeParking.Core.GreetingServer checkSayHello = new NoChangeParking.Core.GreetingServer();
		
		public string sayHello(){
			return checkSayHello.SayHello(name);
		}
	}
}
