using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            Console.WriteLine("{0} ${1}",beverage.getDescription(),beverage.cost());

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1); 
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine("{0} ${1}", beverage1.getDescription(), beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Condiment(beverage2, "Soy", 0.15);
            beverage2 = new Condiment(beverage2, "Mocha", 0.20);
            beverage2 = new Condiment(beverage2, "Whip", 0.10);
            Console.WriteLine("{0} ${1}", beverage2.getDescription(), beverage2.cost());


        }
    }
}
