using AbstractFactory.Products.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private Car car;

        public Client(Factories.AbstractFactory factory)
        {
            car = factory.CreateCar();
        }

        public void Run()
        {
            Console.WriteLine("You are using: {0}", car.GetType().Name);
        }
    }
}
