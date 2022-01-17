using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CarFactory
    {
        public ICar GetCar(string carName)
        {
            if (carName == "Audi")
                return new Audi();
            else if (carName == "Maruti")
                return new Maruti();
            return null;
        }
    }
}
