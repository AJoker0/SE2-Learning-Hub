using System;

class  Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int sum = Add(a, b);
        int result = Subtract(sum, c);

        Console.WriteLine(result);
    }
    static int Add(int a, int b)
    {
        return a + b;

    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    
}