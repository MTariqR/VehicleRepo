using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Driver
    {
        public string name;
        public bool hasLicense;

        public Driver(string Name, bool HasLicense)
        {
            name = Name;  
            hasLicense = HasLicense;
        }
    }
}
