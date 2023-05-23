using System;
using System.Collections.Generic;
using System.Text;

namespace Football_ProjectOOP
{
    public class Game
    {
        public List<FootballPlayer> Team1 { get; set; }
        public List<FootballPlayer> Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }

        public List<Goals> Goals { get; set; }
        public string Result { get; set; }
        public string Winner { get; set; }

        public Game(List<FootballPlayer> team1, List<FootballPlayer> team2, Referee referee, List<Referee> assistantReferees, List<Goals> goals, string result, string winner)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = goals;
            Result = result;
            Winner = winner;
        }

    }
}
