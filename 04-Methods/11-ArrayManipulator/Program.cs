using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            string[] parts = line.Split(' ');
            string cmd = parts[0];

            if (cmd == "exchange")
            {
                int index = int.Parse(parts[1]);
                arr = Exchange(arr, index);
            }
            else if (cmd == "max")
            {
                int result = MaxMin(arr, parts[1], true);
                if (result == -1) Console.WriteLine("No matches");
                else Console.WriteLine(result);
            }
            else if (cmd == "min")
            {
                int result = MaxMin(arr, parts[1], false);
                if (result == -1) Console.WriteLine("No matches");
                else Console.WriteLine(result);
            }
            else if (cmd == "first")
            {
                int count = int.Parse(parts[1]);
                string type = parts[2];
                if (count > arr.Length) Console.WriteLine("Invalid count");
                else Console.WriteLine(FirstLast(arr, count, type, true));
            }
            else if (cmd == "last")
            {
                int count = int.Parse(parts[1]);
                string type = parts[2];
                if (count > arr.Length) Console.WriteLine("Invalid count");
                else Console.WriteLine(FirstLast(arr, count, type, false));
            }
        }

        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }

    static int[] Exchange(int[] arr, int index)
    {
        if (index < 0 || index >= arr.Length)
        {
            Console.WriteLine("Invalid index");
            return arr;
        }
        return arr.Skip(index + 1).Concat(arr.Take(index + 1)).ToArray();
    }

    static int MaxMin(int[] arr, string type, bool isMax)
    {
        int[] filtered = arr.Where(x => type == "even" ? x % 2 == 0 : x % 2 != 0).ToArray();
        if (filtered.Length == 0) return -1;

        int target = isMax ? filtered.Max() : filtered.Min();

        // rightmost index
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == target && (type == "even" ? arr[i] % 2 == 0 : arr[i] % 2 != 0))
                return i;
        }
        return -1;
    }

    static string FirstLast(int[] arr, int count, string type, bool isFirst)
    {
        int[] filtered = arr.Where(x => type == "even" ? x % 2 == 0 : x % 2 != 0).ToArray();

        int[] result = isFirst
            ? filtered.Take(count).ToArray()
            : filtered.TakeLast(count).ToArray();

        return $"[{string.Join(", ", result)}]";
    }
}