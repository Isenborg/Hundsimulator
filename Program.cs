using System;
using System.Collections.Generic;

namespace hundsimulator
{
    class Program
	{
		public static void Main(string[] args)
		{
			var Racing_sim = new Racing_simulator();
			Racing_sim.Run();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}