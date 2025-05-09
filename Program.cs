using System;

namespace DesignPatternDemo
{
    public class OldPrinter
    {
        public void PrintOld()
        {
            Console.WriteLine("Old printing...");
        }
    }

    public interface IPrinter
    {
        void Print();
    }

    public class PrintAdapter : IPrinter
    {
        private OldPrinter oldPrinter = new OldPrinter();

        public void Print()
        {
            oldPrinter.PrintOld();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new PrintAdapter();
            printer.Print();
        }
    }
}