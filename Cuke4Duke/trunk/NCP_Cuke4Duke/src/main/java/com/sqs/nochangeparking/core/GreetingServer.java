package com.sqs.nochangeparking.core;

public class GreetingServer {
	
	private static GreetingServer instance;
	
	private GreetingServer() {
		
	}

	public static GreetingServer getInstance()
	{
		if (instance == null)
			instance = new GreetingServer();
		return instance;
	}
	
	public static String getApplicationName() {
		return "NoChangeParking";
	}
	
	public static String sayHello(String name) {
		if (name.equals("")) {
			return "Hello Stranger";
		} else {
			return "Hello " + name;
		}
	}
	
}
