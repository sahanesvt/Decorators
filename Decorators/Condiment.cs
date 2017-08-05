using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Condiment : CondimentDecorator
    {
        private Beverage beverage;
        private string condimentDescription;
        private double condimentCost;

        public Condiment(Beverage beverage, string condimentDescription, double condimentCost)
        {
            this.beverage = beverage;
            this.condimentDescription = condimentDescription;
            this.condimentCost = condimentCost;
            setDescription();

        }

        private void setDescription()
        {
            description = beverage.getDescription() + ", " + condimentDescription;
        }

        public override double cost()
        {
            return beverage.cost() + condimentCost;
        }

        public override string getDescription()
        {
            setDescription();
            return description;
        }
    }
}
