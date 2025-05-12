using System;

namespace DesignPatternsDemo
{
  
    public class CPU
    {
        public void Start() => Console.WriteLine("CPU started");
    }

 
    public class Memory
    {
        public void Load() => Console.WriteLine("Memory loaded");
    }

    // Facade class
    public class ComputerFacade
    {
        private CPU cpu = new CPU();
        private Memory memory = new Memory();

        public void StartComputer()
        {
            cpu.Start();
            memory.Load();
            Console.WriteLine("Computer Started");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var computer = new ComputerFacade();
            computer.StartComputer();

          
        }
    }
}
