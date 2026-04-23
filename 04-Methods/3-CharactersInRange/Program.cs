using System;

class Program
{
    static void Main()
    {
        char a = Console.ReadLine()[0];
        char b = Console.ReadLine()[0];

        PrintCharsBetween(a, b);
    }

    static void PrintCharsBetween(char a, char b)
    {
        if (a > b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        for (int i = a + 1; i < b; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}