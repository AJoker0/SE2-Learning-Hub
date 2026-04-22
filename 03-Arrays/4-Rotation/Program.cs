using System;

class Program
{
    static void Main()
    {
        string[] parts = Console.ReadLine().Split(' ');
        int rotations = int.Parse(Console.ReadLine());

        rotations = rotations % parts.Length;

        string[] result = new string[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            result[i] = parts[(i + rotations) % parts.Length];
        }
        Console.WriteLine(string.Join(" ", result));
    }
}