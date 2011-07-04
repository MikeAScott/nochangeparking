using System;

namespace NoChangeParking.Core
{
	public class GreetingServer
	{
		public string SayHello(String name) {
			if (name == "") {
				return "Hello Stranger";
			} else {
				return "Hello " + name;
			}
		}
	}
}
