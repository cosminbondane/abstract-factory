﻿using AbstractFactory.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public abstract class AbstractCarFactory
    {
        public abstract Car CreateCar();
    }
}
