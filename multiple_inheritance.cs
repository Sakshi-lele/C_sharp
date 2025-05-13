using System;

interface IWalk
{
    void Walk();
}

interface IRun
{
    void Run();
}

class Person : IWalk, IRun {
    public void Walk()
    {
        Console.WriteLine("Person Walks!");

    }
    public void Run()
    {
        Console.WriteLine("Person Runs!");

    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Walk();
        p.Run();
    }
}
