using System;
using System.Collections.Generic;

namespace hundsimulator
{
     class Dog
        {
            private string Name;
            private int weight;
            private int strength;
            private int stamina;
            private List<race> race_list = new List<race>();
            
            public Dog (string _name, int _weight, int _strength, int _stamina)
            {
                Name = _name;
                strength = _strength;
                weight = _weight;
                stamina = _stamina;
            }
            public void Add_race(int tal1, int tal2, int tal3)
            {
                race_list.Add(new race(tal1, tal2, tal3));
            }
            public void Print_races()
            {
                Console.WriteLine("Statistik över varvtider för {0} : ",Name);
                Console.WriteLine("----------------------------------------------");
                foreach (var race in race_list)
                {
                    Console.WriteLine(race);
                }
            }
            public int calculate_total()
            {
                return 0;
            }

        }
}