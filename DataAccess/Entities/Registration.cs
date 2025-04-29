using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int ClientID { get; set; } 
        public User? Client { get; set; }
        public int TrainingID { get; set; }
        public Training? Training { get; set; }
        public Status RegistrationStatus { set; get; }

        public Registration() { }

        public Registration(int clientID, int trainingID, Status registrationStatus)
        {
            ClientID = clientID;
            TrainingID = trainingID;
            RegistrationStatus = registrationStatus;
        }

        public enum Status
        {
            Registered,
            Cancelled,
            Attended
        }
    }
}
