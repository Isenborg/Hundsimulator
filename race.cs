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
			return string.Format("Varvtid ett: {0}, varvtid två: {1} & varvtid tre{2}", trackOne, trackTwo, trackThree);
		}	

        public double Get_Race_Time()
        {
            double total;
            total = trackOne + trackTwo + trackThree;
            return total;
        }

	} 
}