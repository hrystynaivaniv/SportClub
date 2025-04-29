using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class User
    {
        public int? SeasonTicketID { set; get; }
        public int UserID { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public UserType Type { set; get; }
        public DateTime RegistrationTime { set; get; }
        public SeasonTicketStatus? TicketStatus { set; get; }

        public enum UserType
        {
            Admin,
            Trainer,
            Client
        }
        public enum SeasonTicketStatus
        {
            Active,
            Inactive
        }

        public User() { }

        public User(string name, string email, string number, UserType type, DateTime registration, SeasonTicketStatus seasonTicket)
        {
            Name = name;
            Email = email;
            PhoneNumber = number;
            Type = type;
            RegistrationTime = registration;
            TicketStatus = seasonTicket;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}), Email: {Email}, Phone: {PhoneNumber}, Registered on: {RegistrationTime}, Season Ticket: {TicketStatus}"; 
        }
    }
}
