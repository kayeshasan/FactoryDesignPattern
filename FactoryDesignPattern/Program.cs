using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Car Name:");
            var carName = Console.ReadLine();
            CarFactory car = new CarFactory();
            ICar c = car.GetCar(carName);
            c.BuyCar();
        }
    }
}
