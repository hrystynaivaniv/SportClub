namespace SportClubAPI.Models
{
    public class CreateHallModel
    {
        public int HallNumber { get; set; }
        public string Equipment { get; set; }
        public int Capacity { get; set; }
        public bool Avalaibility { get; set; }
    }
}
