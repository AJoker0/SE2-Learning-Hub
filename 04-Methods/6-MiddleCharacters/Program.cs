using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        PrintMiddle(text);
    }
    static void PrintMiddle(string text)
    {
        int mid = text.Length / 2;

        if (text.Length % 2 == 0)
            Console.WriteLine($"{text[mid - 1]}{text[mid]}");
        else
            Console.WriteLine(text[mid]);
    }
}