using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public DateTime Date { set; get; }
        public TimeSpan Time { set; get; }
        public int TrainingID { get; set; }          
        public Training? Training { get; set; }      
        public int TrainerID { get; set; }          
        public Trainer? Trainer { get; set; }
        public int HallID { set; get; }
        public Hall? Hall { set; get; }
        public int AvailableSpots { set; get; }

        public Schedule() { }

        public Schedule(DateTime date, TimeSpan time, int trainingId, int trainerId, int hallID, int availableSpots)
        {
            Date = date;
            Time = time;
            TrainingID = trainingId;
            TrainerID = trainerId;
            HallID = hallID;
            AvailableSpots = availableSpots;
        }
    }
}
