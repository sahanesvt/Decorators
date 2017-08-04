using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roasted Coffee";
        }
        public override double cost()
        {
            return 0.99;
        }
    }
}
