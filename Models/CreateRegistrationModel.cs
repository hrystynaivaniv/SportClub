using SportClub;
using static SportClub.Registration;

namespace SportClubAPI.Models
{
    public class CreateRegistrationModel
    {
        public int ClientID { get; set; }
        public int TrainingID { get; set; }
        public Status RegistrationStatus { set; get; }
    }
}
