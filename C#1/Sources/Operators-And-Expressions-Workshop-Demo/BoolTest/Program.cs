using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 42;
        bool divideBy3 = number % 3 == 0;
        bool divideBy7 = 42 % 7 == 0;
        bool divide = divideBy3 && divideBy7;
        //Console.WriteLine(divide);
    }
}
