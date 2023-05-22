using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football___2201561028
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
        public int AverageAge
        {
            get
            {
                int totalAge = 0;
                foreach(var player in Players)
                {
                    totalAge += player.Age;
                }
                return totalAge/Players.Count;
            }
        }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;

            // Проверка дали броят играчи е в позволеният диапазон
            if (players.Count < 11 || players.Count > 22)
            {
                throw new Exception("Number of players is out of range");
            }
            else
            {
                Players = players;
            }
        }
    }
}
