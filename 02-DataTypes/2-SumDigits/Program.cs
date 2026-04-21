using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char digit in input)
        {
            sum += digit - '0';
        }
        Console.WriteLine(sum);
    }
}