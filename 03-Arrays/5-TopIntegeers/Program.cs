using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(' ');
        int n = parts.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(parts[i]);

        List<int> tops = new List<int>();
        int maxRight = int.MinValue;

        for (int i = n - 1; i >= 0; i--)
        {
            if (arr[i] > maxRight)
            {
                tops.Add(arr[i]);
                maxRight = arr[i];
            }
        }

        tops.Reverse();
        Console.WriteLine(string.Join(" ", tops));
    }
}