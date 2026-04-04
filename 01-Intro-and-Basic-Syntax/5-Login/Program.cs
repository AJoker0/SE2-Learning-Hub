string username = Console.ReadLine();

string reversed = new string(username.Reverse().ToArray());

for (int attempts = 0; attempts < 4; attempts++)
{
    string input = Console.ReadLine();

    if (input == reversed)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    else if (attempts == 3)
    {
        Console.WriteLine($"User {username} blocked!");
    }
    else
    {
        Console.WriteLine("Incorrect password. Try again.");
    }
}

