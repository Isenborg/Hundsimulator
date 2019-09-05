using System;
using System.Collections.Generic;

namespace hundsimulator
{
     class Dog
        {
            private string Name;
            private double weight;
            private double strength;
            private double stamina;
            private List<race> race_list = new List<race>();

            private double Calculate_Laptime()
            {
            double distance = 400; //400 meter per lap
            double speed = (strength * stamina) / weight; // m/s
            stamina -=  weight/strength;
            double time = distance / speed; //time in seconds
            if (stamina < 0)
            {
                time = 0;
            }
            return Math.Round(time);
            }

            public Dog (string _name, int _weight, int _strength, int _stamina)
            {
                Name = _name;
                strength = _strength;
                weight = _weight;
                stamina = _stamina;
            }
            public void Add_race(Dog dog)
            {
                double startstamina = stamina;
                race_list.Add(new race(Calculate_Laptime(), Calculate_Laptime(), Calculate_Laptime()));
                stamina = startstamina;
            }

            public void Print_Stats(Dog dog)
            {
            Console.WriteLine($"Name: {dog.Name}" +
                $"\n    Weight: {dog.weight}" +
                $"\n    Strength: {dog.strength}" +
                $"\n    Stamina: {dog.stamina}");
            }
            public void Print_races()
            {
                Console.WriteLine("Statistik över varvtider för {0} : ",Name);
                Console.WriteLine("----------------------------------------------");
                foreach (var race in race_list)
                {
                    Console.WriteLine(race);
                }
                Console.WriteLine("");
            }
            
            public double print_only_best_race(double best)
            {
            double BestTime = best;
                foreach (var race in race_list)
                {
                    if(BestTime > race.Get_Race_Time())
                    {
                    BestTime = race.Get_Race_Time();
                    Console.Clear();
                    Console.WriteLine($"Current best time is by Name: {Name}" +
                            $"\n    Weight: {weight}" +
                            $"\n    Strength: {strength}" +
                            $"\n    Stamina: {stamina}");
                    Console.WriteLine(race);
                    }
                }
            return BestTime;
            }

            public int calculate_total()
            {
                return 0;
            }

        }
}