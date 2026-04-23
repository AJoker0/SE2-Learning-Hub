using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        PrintSmallest(a, b, c);

    }
    static void PrintSmallest(int a , int b , int c )
    {
        int smallest = Math.Min(a, Math.Min(b, c));
        Console.WriteLine(smallest);
    }
}