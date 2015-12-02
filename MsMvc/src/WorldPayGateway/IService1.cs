using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WorldPayGateway {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPaymentsService {

        [OperationContract]
        PaymentStatus MakePayment(PaymentRequest paymentDetails);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class PaymentRequest {
        [DataMember]
        public string MerchantId { get; set; }
        [DataMember]
        public string MerchantReference { get; set; }
        [DataMember]
        public string CurrencyCode { get; set; }
        [DataMember]
        public string Amount { get; set; }
        [DataMember]
        public string CardType { get; set; }
        [DataMember]
        public string CardNumber { get; set; }
        [DataMember]
        public string ExpiryDate { get; set; }
        [DataMember]
        public string IssueNumber { get; set; }
        [DataMember]
        public string NameOnCard { get; set; }
        [DataMember]
        public string CVV { get; set; }
     }


    [DataContract]
    public class PaymentStatus {
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string PaymentReference { get; set; }
    }
}
