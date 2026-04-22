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

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
                leftSum += arr[j];

            for (int j = i + 1; j < n; j++)
                rightSum += arr[j];

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("no");
    }
}