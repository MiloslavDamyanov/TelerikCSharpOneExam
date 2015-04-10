using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int maxResultToCheck = 10;

        bool isPrime = ((number % 2 > 0)
            && (number % 3 > 0) && (number % 5 > 0)
            && (number % 7 > 0)) || ((number == 2)
            || (number == 3) || (number == 5)
            || (number == 7));

        Console.WriteLine(isPrime);
    }
}
