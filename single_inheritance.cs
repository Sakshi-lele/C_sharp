using System;

class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
        d.Bark();
    }
}
