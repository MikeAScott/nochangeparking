/*
 * Created by SharpDevelop.
 * User: scottm
 * Date: 29/06/2010
 * Time: 14:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using BigBank.PaymentProcessing;

namespace NoChangeParking.Core
{
	/// <summary>
	/// Description of PaymentProcessor.
	/// </summary>
	public class PaymentProcessor
	{
		
		IPaymentValidator validator;
		
		public PaymentProcessor(IPaymentValidator validator)
		{
			this.validator = validator;
		}

		
		
		public String MakePayment(CreditCard card, Money amount) {
			
			PaymentReceipt receipt = validator.ValidatePayment(card.CardType,card.CardNo,amount.Amount);
			
			if (!receipt.IsValid)
				throw new ArgumentException("Payment rejected: " + receipt.ValidationMessage);
			
			return receipt.ReceiptReference;
		}
		
		
	}
}
