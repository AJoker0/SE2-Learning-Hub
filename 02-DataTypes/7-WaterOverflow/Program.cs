using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int tank = 0;
        int capacity = 255;

        for (int i = 0; i < n; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (tank + liters > capacity)
            {
                Console.WriteLine("Insufficient capacity!");
            } else
            {
                tank += liters;
            }
        }
        Console.WriteLine(tank);

    }
}