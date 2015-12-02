using Multipetros.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WorldPayGateway {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class PaymentsService : IPaymentsService {


        public PaymentStatus MakePayment(PaymentRequest paymentDetails) {
            if (paymentDetails == null) {
                throw new ArgumentNullException("paymentDetails");
            }
            PaymentLog.Log(paymentDetails);
            ProcessDelay();
            if (!PassesLuhnCheck(paymentDetails.CardNumber)) {
                return Rejected("Invalid card number");
            } else if (paymentDetails.CVV.StartsWith("9")) {
                return Rejected("Invalid card details");
            } else if (!paymentDetails.MerchantId.StartsWith("NOCP")) {
                return Rejected("Invalid merchant id");
            } else if (string.IsNullOrEmpty(paymentDetails.MerchantReference)) {
                return Rejected("Merchant reference must be supplied");
            }
            else {
                 return Paid(paymentDetails);
            }
        }

        private bool PassesLuhnCheck(string cardNumber) {
            return Luhn.IsValid(cardNumber);
        }

        private static void ProcessDelay() {
            var rand = new Random();
            var processingTime = 1000 * rand.Next(30);
            System.Threading.Thread.Sleep(processingTime);
        }

        private static PaymentStatus Paid(PaymentRequest paymentDetails) {
            var rand = new Random();
            var status = new PaymentStatus() {
                Status = "Paid",
                Message = paymentDetails.MerchantReference,
                PaymentReference = "400" + rand.Next(1000000)
            };
            PaymentLog.Log(status);
            return status;
        }

        private PaymentStatus Rejected(string message) {
            var status = new PaymentStatus() {
                Status = "Rejected",
                Message = message,
                PaymentReference = ""
            };
            PaymentLog.Log(status);
            return status;
        }
    }
}
