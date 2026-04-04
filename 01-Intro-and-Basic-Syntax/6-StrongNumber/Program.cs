int number = int.Parse(Console.ReadLine());
int sum = 0;

string digits = number.ToString();
foreach (char ch in digits)
{
    int digit = ch - '0';
    int factorial = 1;

    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }
    sum += factorial;
}



Console.WriteLine(number == sum ? "yes" : "no");