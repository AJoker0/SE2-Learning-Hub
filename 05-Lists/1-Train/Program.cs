using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> wagons = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());

        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            if (line.StartsWith("Add"))
            {
                int passengers = int.Parse(line.Split(' ')[1]);
                wagons.Add(passengers);
            }
            else
            {
                int passengers = int.Parse(line);
                for (int i = 0; i < wagons.Count; i++)
                {
                    int space = maxCapacity - wagons[i];
                    if (space >= passengers)
                    {
                        wagons[i] += passengers;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", wagons));
    }
}