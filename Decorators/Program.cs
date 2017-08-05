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
            beverage2 = new Condiment(beverage2, "Soy", 0.15);//create condiment on demand
            beverage2 = new Condiment(beverage2, "Mocha", 0.20);
            beverage2 = new Condiment(beverage2, "Whip", 0.10);
            Console.WriteLine("{0} ${1}", beverage2.getDescription(), beverage2.cost());

            Beverage soy = new Condiment("Soy", 0.15);//define condiment prior to usage without creating additional class
            Beverage mocha = new Condiment("Mocha", 0.20);
            Beverage whip = new Condiment("Whip", 0.10);
            Beverage steamedMilk = new Condiment("Steamed Milk", 0.10);

            Beverage beverage3 = new Decaf();
            beverage3 = new Condiment(beverage3, soy);//use condiment previously defined
            beverage3 = new Condiment(beverage3, mocha);
            beverage3 = new Condiment(beverage3, whip);
            beverage3 = new Condiment(beverage3, steamedMilk);
            Console.WriteLine("{0} ${1}", beverage3.getDescription(), beverage3.cost());


        }
    }
}
