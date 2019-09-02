using System;
using System.Collections.Generic;

namespace hundsimulator
{
    class Racing_simulator
	{
		private List<Dog> dog_list = new List<Dog>();
        private Random r = new Random();
		public void Run()
		{
			Console.WriteLine("Välkommen till denna hundsimulator");
			dog_list.Add(new Dog("Pelle", r.Next(4,10), r.Next(4,10), r.Next(4,10)));
			dog_list.Add(new Dog("Johan", r.Next(4,10), r.Next(4,10), r.Next(4,10)));
			foreach (var hund in dog_list)
			{
				Console.WriteLine(hund);
			}
			foreach (var hund in dog_list)
			{
				hund.Add_race(5,7,8);
			}
			foreach (var hund in dog_list)
			{
				hund.Print_races();
			}
			                          	
		}
	}    
}