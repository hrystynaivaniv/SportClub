using SportClub;

namespace SportClubAPI.Models
{
    public class CreateSeasonTicketModel
    {
        public SeasonTicketType Type { set; get; }
        public decimal Price { set; get; }
        public int DurationD { set; get; }
        public List<string> Services { set; get; }
    }
}
