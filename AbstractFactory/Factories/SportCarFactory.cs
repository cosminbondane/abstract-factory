﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products.Abstract;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class SportCarFactory : AbstractCarFactory
    {
        public override Car CreateCar()
        {
            return new Ferrari();
        }
    }
}
