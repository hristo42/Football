using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football___2201561028
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee[] AssistantReferees { get; set; } = new Referee[2];
        public Game(Team team1, Team team2, Referee mainReferee, Referee assistantReferee1, Referee assistantReferee2)
        {

            // Създаване на нови отбори само с 11те футболиста, които ще играят
            Team1 = new Team(team1.Coach, team1.Players.GetRange(0, 11));
            Team2 = new Team(team2.Coach, team2.Players.GetRange(0, 11));

            Referee = mainReferee;
            AssistantReferees[0] = assistantReferee1;
            AssistantReferees[1] = assistantReferee2;
        }
        public List<Goal> Goals { get; set; } = new List<Goal>();
        public int ScoreForTeam1 = 0;
        public int ScoreForTeam2 = 0;
        public void Goal(Goal goal)
        {

            // Проверка за кой отбор е отбелязаният гол
            if (Team1.Players.Contains(goal.Scorer))
            {
                ScoreForTeam1++;
            }
            else if(Team2.Players.Contains(goal.Scorer))
            {
                ScoreForTeam2++;
            }
            else
            {
                throw new Exception("This player isn't part of this game");
            }
        }

        // Разпечатване на резултата
        public void GameResult()
        {
            Console.WriteLine($"{ScoreForTeam1} : {ScoreForTeam2}");
        }

        // Разпечатване на победителя, ако има такъв
        public void Winner()
        {
            if (ScoreForTeam2 > ScoreForTeam1)
            {
                Console.WriteLine("The winner is Team 2");
            }
            else if (ScoreForTeam1 > ScoreForTeam2)
            {
                Console.WriteLine("The winner is Team 1");
            }
            else
            {
                Console.WriteLine("The game is a draw");
            }
        }
    }
}
