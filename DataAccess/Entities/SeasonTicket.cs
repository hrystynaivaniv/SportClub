using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class SeasonTicket
    {
        public int SeasonTicketID { set; get; }
        public SeasonTicketType Type { set; get; }
        public decimal Price { set; get; }
        public int DurationD { set; get; }
        public List<string>Services { set; get; }

        public SeasonTicket() { }

        public SeasonTicket(SeasonTicketType type, decimal price, int duration, List<string> services)
        {
            Type = type;
            Price = price;
            DurationD = duration;
            Services = services;
        }
    }

    public enum SeasonTicketType
    {
        SingleEntry,
        Monthly,
        Yearly
    }
}
