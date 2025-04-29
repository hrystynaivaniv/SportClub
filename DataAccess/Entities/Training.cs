using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportClub
{
    public class Training
    {
        public int TrainingID { set; get; }
        public string Name { set; get; }
        public TrainingCategory Category { set; get; }
        public int TrainerID { get; set; }
        public Trainer? Trainer { get; set; }
        public int HallID { set; get; }
        public Hall? Hall { set; get; }
        public DateTime Date { set; get; }
        public TimeSpan Time { set; get; }
        public TimeSpan Duration { set; get; }
        public int Participants { set; get; }

        public Training() { }

        public Training(string name, TrainingCategory category, int trainerId, int hallID, DateTime date, TimeSpan time, TimeSpan duration, int participants)
        {
            Name = name;
            Category = category;
            TrainerID = trainerId;
            HallID = hallID;
            Date = date;
            Time = time;
            Duration = duration;
            Participants = participants;
        }
    }

    public enum TrainingCategory
    {
        Group,
        Individual
    }

}
