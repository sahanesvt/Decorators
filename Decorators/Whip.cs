using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Whip:CondimentDecorator
    {
        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            setDescription();
        }

        private void setDescription()
        {
            description = beverage.getDescription() + ", Whip";
        }

        public override string getDescription()
        {
            setDescription();
            return description;
        }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
