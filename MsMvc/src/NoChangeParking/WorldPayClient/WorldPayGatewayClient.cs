using NoChangeParking.Models;
using NoChangeParking.WorldPayGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoChangeParking.WorldPayClient
{
    public class PaymentResponse
    {
        public String Status { get; set; }
        public string Message { get; set; }
        public string PaymentReference { get; set; }
    }


    public class WorldPayGatewayClient
    {
        public PaymentResponse MakePayment(PaymentDetails payment)
        {
            var service=new PaymentsServiceClient();
            var paymentRequest=new PaymentRequest()
            {
                Amount="5.00",
                NameOnCard=payment.NameOnCard,
                CardNumber=payment.CardNumber,
                CardType=payment.CardType.ToString(),
                CVV=payment.CardCVCNumeber,
                ExpiryDate=payment.CardExpiry.ToString(),
                IssueNumber=payment.CardIssueNumeber,
                MerchantId = "NOCP15235",
                MerchantReference = "No Change Parking payment for " + payment.RegistrationPlate + " on " + DateTime.Now,
                CurrencyCode = "GBP"
            };
            var status = service.MakePayment(paymentRequest);
            return new PaymentResponse()
            {
                Status=status.Status,
                Message=status.Message,
                PaymentReference=status.PaymentReference
            };
        }

    }
}