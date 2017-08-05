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
        private string condimentDescription = "Unknown Beverage";
        private double condimentCost = 0;

        public Condiment(Beverage beverage, string condimentDescription, double condimentCost):this(condimentDescription,condimentCost)
        {
            this.beverage = beverage;
            setStuff();
        }

        public Condiment(string condimentDescription, double condimentCost)
        {
            this.condimentDescription = condimentDescription;
            this.condimentCost = condimentCost;
            setStuff();
        }

        public Condiment(Beverage beverage, Beverage condiment):this(condiment.getDescription(),condiment.cost())
        {
            this.beverage = beverage;
            setStuff();
        }

        private void setDescription()
        {
            if (beverage != null)
            {
                description = beverage.getDescription() + ", " + condimentDescription;
            }
            else
            {
                description = condimentDescription;
            }
        }

        private void setCost()
        {
            if (beverage != null)
            {
                condimentCost += beverage.cost();
            }
        }

        private void setStuff()
        {
            setDescription();
            setCost();
        }

        public override double cost()
        {
            return condimentCost;
        }

        public override string getDescription()
        {
            setDescription();
            return description;
        }

    }
}
