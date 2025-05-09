using System;

namespace DesignPatternsDemo
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        public static Singleton Instance => _instance;

        private Singleton () { }

        public void Log(string message) { 
        Console.WriteLine(message); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Log("Hello from Singleton!");
        }
    }
}
