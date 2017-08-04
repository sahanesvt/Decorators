using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Mocha:CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            description = beverage.getDescription() + ", Mocha";
            return description;
        }

        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}
