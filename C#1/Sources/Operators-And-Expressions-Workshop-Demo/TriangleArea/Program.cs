using System;

class Program
{
    static void Main(string[] args)
    {
        double a = 5.0;
        double b = 3.0;
        double angle = 30;

        double area = a * b * Math.Sin(30) / 2;

        Console.WriteLine(area);
    }
}
