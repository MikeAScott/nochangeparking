using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WorldPayGateway {
    public class PaymentLog {

        private const string LOGFILE = @"C:\Logs\PaymentsLog.csv";

        public static void Log(PaymentRequest request) {
            using (var stream = File.AppendText(LOGFILE)) {
                var line = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                    DateTime.Now,
                    "Payment Request",
                    request.MerchantId,
                    request.MerchantReference,
                    request.CurrencyCode,
                    request.Amount,
                    request.CardType,
                    request.CardNumber,
                    request.NameOnCard);
                stream.WriteLine(line);
            } 
        }

        public static void Log(PaymentStatus status) {
            using (var stream = File.AppendText(LOGFILE)) {
                var line = String.Format("{0},{1},{2},{3},{4}",
                    DateTime.Now, 
                    "Payment Status",
                    status.Status,
                    status.Message,
                    status.PaymentReference);
                stream.WriteLine(line);
            }
        }

    }
}