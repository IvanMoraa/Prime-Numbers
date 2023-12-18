using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        try{
        Console.WriteLine("Write a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{number} es un número primo.");
        else
            Console.WriteLine($"{number} no es un número primo.");
    }catch(Exception ex)
    {
        System.Console.WriteLine($"Ha ocurrido el siguiente error: {ex}");
    }
    }
}