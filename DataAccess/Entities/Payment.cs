using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Payment
    {
            public int PaymentID { get; set; }              
            public int ClientID { get; set; }
            public User? Client { get; set; }
            public decimal Amount { get; set; }            
            public PaymentType Type { get; set; }           
            public DateTime PaymentDate { get; set; }

        public enum PaymentType
        {
            SeasonTicket,
            SingleSession
        }

        public Payment() { }

        public Payment(int clientID, decimal amount, PaymentType paymentType, DateTime paymentDate)
        {
            ClientID = clientID;
            Amount = amount;
            Type = paymentType;
            PaymentDate = paymentDate;
        }
    }
}
