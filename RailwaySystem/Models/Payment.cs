using System;
namespace RailwaySystem.Models
{

    public struct Payment
    {
        public string PaymentID { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public decimal Fine { get; set; }
        public User BookingAgent { get; set; }

        public Payment(string paymentID, string transactionNumber, DateTime transactionDateTime, string type, decimal value, User bookingAgent, decimal fine = 0)
        {
            PaymentID = paymentID ?? throw new ArgumentNullException(nameof(paymentID));
            TransactionNumber = transactionNumber ?? throw new ArgumentNullException(nameof(transactionNumber));
            TransactionDateTime = transactionDateTime;
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Value = value;
            Fine = fine;
            BookingAgent = bookingAgent ?? throw new ArgumentNullException(nameof(bookingAgent));
        }
    }
}
