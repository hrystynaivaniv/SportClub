using SportClub;

namespace SportClubAPI.Models
{
    public class CreateTrainingModel
    {
        public string Name { set; get; }
        public TrainingCategory Category { set; get; }
        public int TrainerID { get; set; }
        public int HallID { set; get; }
        public DateTime Date { set; get; }
        public TimeSpan Time { set; get; }
        public TimeSpan Duration { set; get; }
        public int Participants { set; get; }
    }
}
