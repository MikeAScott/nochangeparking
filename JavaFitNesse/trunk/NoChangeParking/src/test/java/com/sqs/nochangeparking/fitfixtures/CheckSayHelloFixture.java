package com.sqs.nochangeparking.fitfixtures;

import fit.ColumnFixture;
import com.sqs.nochangeparking.core.*;

public class CheckSayHelloFixture extends ColumnFixture{

	public String name;
	
	public String sayHello() {
		return GreetingServer.sayHello(name);
	}
	
}
