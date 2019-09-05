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
            ConsoleKeyInfo key;
            do
            {
                if(dog_list.Count > 0)
                {
                    Console.WriteLine("List of dogs:");
                    foreach(var dog in dog_list)
                    {
                        dog.Print_Stats(dog);
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("[1]- Add dog" +
                    "\n[2]- Start race" +
                    "\n[3]- Clear all dogs" +
                    "\n[4]- Find fastest breed of dog" +
                    "\n[5]- Make custom dog");
                key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1':
                        Console.Write("Choose name for dog: ");
                        string name = Console.ReadLine();
                        dog_list.Add(new Dog(name, r.Next(4, 10), r.Next(4, 10), r.Next(4, 10)));
                        break;

                    case '2':
                        if(dog_list.Count > 0)
                        {
                            Start_race();
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Console.WriteLine("No dogs available...");
                            Console.ReadKey(true);
                        }
                        break;

                    case '3':
                        dog_list.Clear();
                        break;

                    case '4':
                        Console.Write("How many dogs do you want to simulate?" +
                            "\nEnter here: ");
                        int DogAmount = 0;
                        while(!int.TryParse(Console.ReadLine(), out DogAmount))
                        {
                            Console.Write("Enter a valid number: ");
                        }
                        for(int i = 0; i < DogAmount; i++)
                        {
                            dog_list.Add(new Dog($"Dog#{i}", r.Next(4, 10), r.Next(4, 10), r.Next(4, 10)));
                        }
                        foreach (var hund in dog_list)
                        {
                            hund.Add_race(hund);
                        }
                        Console.Clear();
                        double time = 1000;
                        foreach(var hund in dog_list)
                        {
                            time = hund.print_only_best_race(time);
                            System.Threading.Thread.Sleep(50);
                        }
                        Console.WriteLine("Simulation Completed...");
                        Console.ReadKey(true);
                        dog_list.Clear();
                        break;

                    case '5':
                        Console.Write("Choose name for dog: ");
                        string dogname = Console.ReadLine();
                        Console.Write("Choose weight for dog: ");
                        int dogweight;
                        while (!int.TryParse(Console.ReadLine(), out dogweight))
                        {
                            Console.Write("Enter a valid number: ");
                        }
                        Console.Write("Choose strength for dog: ");
                        int dogstr;
                        while (!int.TryParse(Console.ReadLine(), out dogstr))
                        {
                            Console.Write("Enter a valid number: ");
                        }
                        Console.Write("Choose stamina for dog: ");
                        int dogstamina;
                        while (!int.TryParse(Console.ReadLine(), out dogstamina))
                        {
                            Console.Write("Enter a valid number: ");
                        }
                        dog_list.Add(new Dog(dogname, dogweight, dogstr, dogstamina));

                        break;
                }
                Console.Clear();
            } while (true);           	
		}
        public void Start_race()
        {
            foreach (var hund in dog_list)
            {
                hund.Add_race(hund);
            }
            foreach (var hund in dog_list)
            {
                hund.Print_races();
            }

        }
    }    
}