using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Prius");
            car.Start();

            Console.WriteLine(car.GetName());
        }
    }
}
