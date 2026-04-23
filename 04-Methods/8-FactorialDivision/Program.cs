using System;

class Program 
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        double result = Factorial(a) / Factorial(b);
        Console.WriteLine($"{result:F2}");
    }

    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
}