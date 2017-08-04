using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Decaf:Beverage
    {
        public Decaf()
        {
            description = "Decaffinated Coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
