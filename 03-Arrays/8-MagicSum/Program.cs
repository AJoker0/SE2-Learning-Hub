using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(' ');
        int n = parts.Length;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++) 
            arr[i] = int.Parse(parts[i]);

        int target = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine($"{arr[i]} {arr[j]}");
                }
            }
        }
    }
}