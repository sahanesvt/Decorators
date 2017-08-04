using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public abstract class Beverage
    {
        internal string description = "Unknown Beverage";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
