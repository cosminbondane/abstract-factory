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
            Factories.AbstractFactory fact1 = new SportFactory();
            Client c1 = new Client(fact1);
            c1.Run();

            Factories.AbstractFactory fact2 = new CityFactory();
            Client c2 = new Client(fact2);
            c2.Run();

            Console.ReadKey();
        }
    }
}
