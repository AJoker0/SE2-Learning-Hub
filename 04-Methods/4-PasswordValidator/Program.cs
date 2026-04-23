using System;

class Program
{
    static void Main()
    {
        string password = Console.ReadLine();
        bool isValid = true;

        if (!IsValidLength(password))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        if (!IsOnlyLettersAndDigits(password))
        {
            Console.WriteLine("Password must consist only of letters and digits");
            isValid = false;
        }

        if (!HasAtLeastTwoDigits(password))
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        if (isValid)
            Console.WriteLine("Password is valid");
    }

    static bool IsValidLength(string password)
    {
        return password.Length >= 6 && password.Length <= 10;
    }

    static bool IsOnlyLettersAndDigits(string password)
    {
        foreach (char ch in password)
        {
            if (!char.IsLetterOrDigit(ch))
                return false;
        }
        return true;
    }

    static bool HasAtLeastTwoDigits(string password)
    {
        int count = 0;
        foreach (char ch in password)
        {
            if (char.IsDigit(ch))
                count++;
        }
        return count >= 2;
    }
}