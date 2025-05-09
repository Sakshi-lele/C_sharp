using System;

namespace DesignPatternDemo
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Person : Prototype
    {
        public string Name;
        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Sakshi" };
            Person p2 = (Person)p1.Clone();

            Console.WriteLine(p2.Name);
        }
    }
}