using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long m = long.Parse(Console.ReadLine());
        long y = long.Parse(Console.ReadLine());

        long originalN = n;
        int count = 0;

        while (n >= m)
        {
            n -= m;
            count++;

            if (2 * n == originalN && y != 0)
            {
                n /= y;
            }
        }
        Console.WriteLine(n);
        Console.WriteLine(count);
    }
}