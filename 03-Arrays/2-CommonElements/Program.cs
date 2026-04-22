using System;

class  Program
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split(' ');
        string[] second = Console.ReadLine().Split(' ');

        foreach (string item in second)
        {
            if (Array.IndexOf(first, item) != -1)
            {
                Console.Write(item + " ");
            }
        }
    }
}