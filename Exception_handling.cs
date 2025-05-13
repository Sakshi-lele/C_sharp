using System;

class Program
{
    static void Main()
    {
        int numerator = 10;
        int denominator = 0;

        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine("Exception Message: " + ex.Message);
        }
    }
}
