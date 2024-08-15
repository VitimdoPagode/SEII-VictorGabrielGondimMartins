using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video12
{
    public class RealState
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        
        public int CalculatePricePerSquareFoot() => Price / SquareFootage;

    }
}