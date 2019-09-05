using System;
using System.Collections.Generic;

namespace hundsimulator
{
   class race
	{
		private double trackOne;
		private double trackTwo;
		private double trackThree;
		
		public race(double _trackOne, double _trackTwo, double _trackThree)
		{
			trackOne=_trackOne;
			trackTwo=_trackTwo;
			trackThree=_trackThree;
		}
		
		public override string ToString()
		{
            if (trackOne == 0 || trackTwo == 0 || trackThree == 0)
            {
                return string.Format("Gave up");
            }
            else
            {
                return string.Format("Lap one: {0} Seconds " +
                    "\nLap two: {1} Seconds " +
                    "\nLap three: {2} Seconds" +
                    "\nTotal time: {3} Seconds", trackOne, trackTwo, trackThree, Get_Race_Time());
            }
            
		}	

        public double Get_Race_Time()
        {
            double total;
            total = trackOne + trackTwo + trackThree;
            return total;
        }
        
        public double Check_if_best(double best)
        {
            if(best > Get_Race_Time())
            {
                best = Get_Race_Time();
            }
            return best;
        }

	} 
}