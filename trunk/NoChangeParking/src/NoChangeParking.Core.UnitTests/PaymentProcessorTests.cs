/*
 * Created by SharpDevelop.
 * User: scottm
 * Date: 29/06/2010
 * Time: 14:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using Rhino.Mocks;
using BigBank.PaymentProcessing;
using NoChangeParking.Core;

namespace NoChangeParking.Core.UnitTests
{
	[TestFixture]
	public class PaymentProcessorTests
	{
		[Test]
		public void ValidPaymentReturnsReference() {
			MockRepository mocks = new MockRepository();
			
			IPaymentValidator mockValidator = mocks.CreateMock<IPaymentValidator>();
			
			PaymentProcessor processor = new PaymentProcessor(mockValidator);
			
			Expect.Call(mockValidator.ValidatePayment("Amex","1234567890123456",100))
				.Return(new PaymentReceipt(true,"Ref123"));
			
			mocks.ReplayAll();
			
			CreditCard cc = new CreditCard("Amex","1234567890123456","Cust1");
			Money amt = new Money("GBP",100);
			
			String message = processor.MakePayment(cc,amt);
			
			Assert.AreEqual("Ref123", message);
			
			mocks.VerifyAll();
		}
	
		class MockValidator: IPaymentValidator {
			
			
			public PaymentReceipt ValidatePayment(string cardType, string cardNo, decimal amount)
			{
				return new PaymentReceipt(true,"PaymentAccepted");
				throw new NotImplementedException();
			}
		}
		
		
	}
	
	
}
