using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i;


        Console.WriteLine("Please type a number: ");
        i = int.Parse(Console.ReadLine());

        if ((i % 3) == 0 && (i % 5) == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if ((i % 3) == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if ((i % 5) == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }

    }
}
