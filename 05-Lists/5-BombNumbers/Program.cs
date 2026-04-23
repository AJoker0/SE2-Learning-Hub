using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();
        string[] bombInfo = Console.ReadLine().Split(' ');
        int bomb = int.Parse(bombInfo[0]);
        int power = int.Parse(bombInfo[1]);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bomb)
            {
            int left = Math.Max(0, i - power);
            int right = Math.Min(numbers.Count - 1, i + power);
            int removeCount = right - left + 1;
            numbers.RemoveRange(left, removeCount);
            i = left - 1; //restart from explosion
            }
        }
        Console.WriteLine(numbers.Sum());
    }
}