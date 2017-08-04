﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorators
{
    public class Expresso:Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
