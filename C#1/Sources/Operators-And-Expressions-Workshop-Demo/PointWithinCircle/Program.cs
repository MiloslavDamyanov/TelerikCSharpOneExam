using System;

class Program
{
    static void Main()
    {
        decimal pointX = 4.6m;
        decimal pointY = -4.3m;
        decimal centerX = -1.0m;
        decimal centerY = 2.5m;

        decimal resultX = (pointX - centerX)
            * (pointX - centerX);
        decimal resultY = (pointY - centerY)
            * (pointY - centerY);

        decimal endResult = resultX + resultY;

        decimal radius = 5;

        bool isWithinCircle = endResult <
            radius * radius;

        Console.WriteLine(isWithinCircle);
    }
}
