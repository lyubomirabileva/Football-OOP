using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace Football_ProjectOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> team1 = new List<FootballPlayer>();
            string name = "";
            int number = 0;
            int age = 0;
            double height = 0;
            for (int team1Num = 1; team1Num <= 11; team1Num++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(',');
                if (data[0] == "goalkeeper")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Goalkeeper goalkeeper = new Goalkeeper(name, number, age, height);
                    team1.Add(goalkeeper);
                }
                else if (data[0] == "defender")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Defender defender = new Defender(name, number, age, height);
                    team1.Add(defender);
                    
                }
                else if (data[0] == "midfield")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Midfield midfield = new Midfield(name, number, age, height);
                    team1.Add(midfield);
                }
                else if (data[0] == "striker")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Striker striker = new Striker(name, number, age, height);
                    team1.Add(striker);
                }
                
            }

            List<FootballPlayer> team2 = new List<FootballPlayer>();
            for (int team2Num = 1; team2Num <= 11; team2Num++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split(',');
                if (data[0] == "goalkeeper")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Goalkeeper goalkeeper = new Goalkeeper(name, number, age, height);
                    team2.Add(goalkeeper);
                }
                else if (data[0] == "defender")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Defender defender = new Defender(name, number, age, height);
                    team2.Add(defender);

                }
                else if (data[0] == "midfield")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Midfield midfield = new Midfield(name, number, age, height);
                    team2.Add(midfield);
                }
                else if (data[0] == "striker")
                {
                    name = data[1];
                    number = int.Parse(data[2]);
                    age = int.Parse(data[3]);
                    height = int.Parse(data[4]);
                    Striker striker = new Striker(name, number, age, height);
                    team2.Add(striker);
                }

            }




        }
    }
}
