using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football___2201561028
{
    public abstract class FootballPlayer : Person
    {
        public int Number { get; set; }
        public int Height { get; set; }
        public FootballPlayer(string name, int number, int age, int height)
            : base(name, age) 
        {
            Number = number;
            Height = height;
        }
    }
}
