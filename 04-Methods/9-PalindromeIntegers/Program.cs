using System;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != "END")
        {
            Console.WriteLine(IsPalindrome(line));
        }
    }
    static bool IsPalindrome(String text)
    {
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}