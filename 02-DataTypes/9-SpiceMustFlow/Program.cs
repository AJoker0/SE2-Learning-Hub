using System;

class Program
{
    static void Main()
    {
        int yield = int.Parse(Console.ReadLine());
        int totalSpice = 0;
        int days = 0;

        while (yield >= 100)
        {
            totalSpice += yield;
            totalSpice -= 26; //workers eat 26
            days++;
            yield -= 10; //yield drops for next day 

        }
        totalSpice -= Math.Min(26, totalSpice);

        Console.WriteLine(days);
        Console.WriteLine(totalSpice);
    }
}