using SportClub;

namespace SportClubAPI.Models
{
    public class CreateScheduleModel
    {
        public DateTime Date { set; get; }
        public TimeSpan Time { set; get; }
        public int TrainingID { get; set; }
        public int TrainerID { get; set; }
        public int HallID { set; get; }
        public int AvailableSpots { set; get; }
    }
}
