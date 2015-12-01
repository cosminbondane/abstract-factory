using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factories.AbstractCarFactory fact1 = new SportCarFactory();
            Client c1 = new Client(fact1);
            c1.Run();

            Factories.AbstractCarFactory fact2 = new CityCarFactory();
            Client c2 = new Client(fact2);
            c2.Run();

            Console.ReadKey();
        }
    }
}
