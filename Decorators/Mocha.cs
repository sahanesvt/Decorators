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
            setDescription();
        }

        private void setDescription()
        {
            description = beverage.getDescription() + ", Mocha";
        }

        public override string getDescription()
        {
            setDescription();
             return description;
        }

        public override double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}
