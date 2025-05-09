using System;

namespace DesignPatternsDemo
{
    public class Car
    {
        public string Engine, Wheels;
        public override string ToString() => $"Engine: {Engine}, Wheels: {Wheels}";
    }

    public class CarBuilder
    {
        private Car car = new Car();
        public CarBuilder SetEngine (string engine)
        {
            car.Engine = engine;
            return this ;
        }
        public CarBuilder SetWheels(string wheels)
        {
            car.Wheels = wheels;
            return this ;
        }
        public Car Build() => car;
    }

    class Program
    {
        static void Main(string[] args) {
            Car car = new CarBuilder()
                .SetEngine("V8")
                .SetWheels("Alloy")
                .Build();

            Console.WriteLine(car);
        }
    }

}
