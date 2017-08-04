using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class SteamedMilk:CondimentDecorator
    {
        private Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            description = beverage.getDescription() + ", Steamed Milk";
            return description;
        }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
