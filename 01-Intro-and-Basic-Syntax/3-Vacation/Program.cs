int count = int.Parse(Console.ReadLine());

string type = Console.ReadLine();
string day = Console.ReadLine();

double price = 0;
double amount = 0;
if (count > 0)
{
    if (type == "Students")
    {
        if (day == "Friday")
        {
            price = 8.45;
        }
        else if (day == "Saturday")
        {
            price = 9.80;
        }
        else if (day == "Sunday")
        {
            price = 10.46;
        }
    }
    else if (type == "Business")
    {
        if (day == "Friday")
        {
            price = 10.90;
        }
        else if (day == "Saturday")
        {
            price = 15.60;
        }
        else if (day == "Sunday")
        {
            price = 16;
        }
    }
    else if (type == "Regular")
    {
        if (day == "Friday")
        {
            price = 15;
        }
        else if (day == "Saturday")
        {
            price = 20;
        }
        else if (day == "Sunday")
        {
            price = 22.50;
        }
    }
    amount = count * price;
    if (type == "Students" && count >= 30)
    {
        amount *= 0.85;
    }
    else if (type == "Business" && count >= 100)
    {
        amount -= 10 * price;
    }
    else if (type == "Regular" && count >= 10 && count <= 20)
    {
        amount *= 0.95;
    }
}

Console.WriteLine($"Total price: {amount:F2}");