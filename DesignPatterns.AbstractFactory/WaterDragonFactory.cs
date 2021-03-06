﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class WaterDragonFactory : IElementalFactory
    {
        public Dragon CreateDragon()
        {
            return new Dragon { Elemental = Dragon.ElementalType.Water };
        }
    }
}
