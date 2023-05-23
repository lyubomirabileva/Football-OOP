using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Football_ProjectOOP
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double AverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Count;
        }
    }
}
