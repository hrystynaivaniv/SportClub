using SportClub;
using static SportClub.Payment;

namespace SportClubAPI.Models
{
    public class CreatePaymentModel
    {
        public int ClientID { get; set; }
        public decimal Amount { get; set; }
        public PaymentType Type { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
