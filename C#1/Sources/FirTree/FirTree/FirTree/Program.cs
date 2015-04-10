using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int starCount = 3;
        int dotCount = n - 2;

        string firstLine = new string('.', dotCount) + '*' +
                           new string('.', dotCount);

        dotCount--;
        Console.WriteLine(firstLine);
        for (int i = 1; i < n - 1; i++)
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', starCount));
            Console.Write(new string('.', dotCount));
            Console.WriteLine();
            dotCount--;
            starCount += 2;
        }

        Console.WriteLine(firstLine);
    }
}