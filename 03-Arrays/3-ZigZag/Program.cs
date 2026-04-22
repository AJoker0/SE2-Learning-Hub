using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);

            if (i % 2 == 0) //even index
            {
                arr1[i] = a;
                arr2[i] = b;
            } else
            {
                arr1[i] = b;
                arr2[i] = a;
            }

        }
        Console.WriteLine(string.Join(" ", arr1));
        Console.WriteLine(string.Join(" ", arr2));
    }
}