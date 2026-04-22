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

        int bestStart = 0;
        int bestLength = 1;
        int currStart = 0;
        int currLength = 1;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currLength++;
            } else
            {
                currStart = i;
                currLength = 1;
            }
            if (currLength > bestLength)
            {
                bestStart = currStart;
                bestLength = currLength;
            }
        }
        int[] result = new int[bestLength];
        for (int i = 0; i < bestLength; i++)
            result[i] = arr[bestStart + i];

        Console.WriteLine(string.Join(" ", result));
    }
}