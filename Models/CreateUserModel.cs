using static SportClub.User;

namespace SportClubAPI.Models
{
    public class CreateUserModel
    {
        public int? SeasonTicketID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public UserType Type { set; get; }
        public DateTime RegistrationTime { set; get; }
        public SeasonTicketStatus? TicketStatus { set; get; }

    }
}
