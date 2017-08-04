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
            var beverage = new Expresso();
            Console.WriteLine("{0} ${1}",beverage.getDescription(),beverage.cost());

            var darkRoast = new DarkRoast();
            var darkRoastWithMocha = new Mocha(darkRoast); // can't set darkRoast = new Mocha(darkRoast); ????
            var darkRoastDoubleMocha = new Mocha(darkRoastWithMocha);
            var darkRoastDoubleMochaWhip = new Whip(darkRoastDoubleMocha);
            Console.WriteLine("{0} ${1}", darkRoastDoubleMochaWhip.getDescription(), darkRoastDoubleMochaWhip.cost());// loses track of description somewhere and defaults to abstract parent class default

        }
    }
}
