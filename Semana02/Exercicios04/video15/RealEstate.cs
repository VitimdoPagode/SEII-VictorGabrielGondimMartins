using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace video15
{
    public class RealEstate 
    {
        private string _address; // field
        public RealEstate(string address)
        {
            _address = address;
        }
        public string Address 
        { 
            get => _address; 
            set => _address = value;
        }
    }

}