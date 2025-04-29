using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Trainer
    {
        public int TrainerID { get; set; }          
        public string Name { get; set; }           
        public string Specialization { get; set; }     
        public int Experience { get; set; }     
        public Schedule? Schedule { get; set; } 
        public float Rating { get; set; }

        public Trainer() { }

        public Trainer(string name, string specialization, int experience, float rating)
        {
            Name = name;
            Specialization = specialization;
            Experience = experience;
            Rating = rating;
        }
    }
}
