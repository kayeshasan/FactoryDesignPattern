using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Maruti : ICar
    {
        public void BuyCar()
        {
            Console.WriteLine("I want to buy Maruti");
        }
    }
}
