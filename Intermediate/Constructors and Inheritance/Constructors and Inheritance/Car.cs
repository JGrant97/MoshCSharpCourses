using System;

namespace Constructors_and_Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised. {0}", registrationNumber);
        }
    }
}
