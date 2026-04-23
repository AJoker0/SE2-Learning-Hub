using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        PrintVowelsCount(input);
    }
    static void PrintVowelsCount(string text)
    {
        int count = 0;
        string vowels = "aeiouAEIOU";


        foreach (char ch in text)
        {
            if (vowels.Contains(ch))
                count++;
        
        }
        Console.WriteLine(count);
    }


}