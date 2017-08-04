using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Soy: CondimentDecorator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            description = beverage.getDescription() + ", Soy";
            return description;
        }

        public override double cost()
        {
            return beverage.cost() + 0.15;
        }
    }
}
