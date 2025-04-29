using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Hall
    {
        public int HallID { get; set; }
        public int HallNumber { get; set; }
        public string Equipment { get; set; }
        public int Capacity { get; set; }
        public bool Avalaibility { get; set; }

        public Hall () { }

        public Hall(int hallNumber, string equipment, int capacity, bool avalaibility)
        {
            HallNumber = hallNumber;
            Equipment = equipment;
            Capacity = capacity;
            Avalaibility = avalaibility;
        }

    }
}
