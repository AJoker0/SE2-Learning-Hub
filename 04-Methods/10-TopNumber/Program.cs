using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (HasDigitSumDivisibleBy8(i) && HasOddDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool HasDigitSumDivisibleBy8(int num)
    {
        int sum = 0;

        foreach (char ch in num.ToString())
        {
            sum += ch - '0';
        }

        return sum % 8 == 0;
    }

    static bool HasOddDigit(int num)
    {
        foreach (char ch in num.ToString())
        {
            if ((ch - '0') % 2 != 0)
            {
                return true;
            }
        }

        return false;
    }
}