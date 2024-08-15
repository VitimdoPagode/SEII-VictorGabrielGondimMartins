using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace video16
{
    public class Savings
    {
        public static double courrInterestRate;
        public static double bondRate;

        static Savings()
        {
            courrInterestRate = 0.4;
        }
        public static void AddBondRate()
        {
            courrInterestRate = bondRate + 0.1;
        }

    }
}