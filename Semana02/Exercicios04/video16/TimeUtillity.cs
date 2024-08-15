using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video16
{
    public static class TimeUtillity
    {
        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}