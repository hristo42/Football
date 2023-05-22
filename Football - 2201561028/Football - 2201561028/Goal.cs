using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football___2201561028
{
    public class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Scorer { get; set; }
        public Goal(int minute, FootballPlayer scorer)
        {
            Minute = minute;
            Scorer = scorer;
        }
    }
}
