double balance = 0;
double[] validCoins = { 0.1, 0.2, 0.5, 1, 2 };

var products = new Dictionary<string, double>
{
    ["Nuts"] = 2.0,
    ["Water"] = 0.7,
    ["Crisps"] = 1.5,
    ["Soda"] = 0.8,
    ["Coke"] = 1.0
};

while (true)
{
    string input = Console.ReadLine();
    if (input == "Start") break;

    if (double.TryParse(input, out double coin))
    {
        if (validCoins.Contains(coin))
        {
        balance += coin;
        } 
        else
        {
               Console.WriteLine($"Cannot accept {coin}");
        }
    }
else
{
    Console.WriteLine($"Cannot accept {input}");
}

}
while (true)
{
    string product = Console.ReadLine();
    if (product == "End") break;

    if (products.ContainsKey(product))
    {
        double price = products[product];
        if (balance >= price)
        {
            balance -= price;
            Console.WriteLine($"Purchased {product}");

        }
        else
        {
             Console.WriteLine("Sorry, not enough money");

        }
        
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
    
}
Console.WriteLine($"Change: {balance:F2}");

