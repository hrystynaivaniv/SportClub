using SportClub;

namespace SportClubAPI.Models
{
    public class CreateTrainerModel
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Experience { get; set; }
        public float Rating { get; set; }
    }
}
