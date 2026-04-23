using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Queue<int> first = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        Queue<int> second = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        while (first.Count > 0 && second.Count > 0)
        {
            int a = first.Dequeue();
            int b = second.Dequeue();

            if (a > b)
            {
                first.Enqueue(b);
                first.Enqueue(a);
            }
            else if (b > a){
                second.Enqueue(a);
                second.Enqueue(b);
            }

        }
        if (first.Count > 0)
            Console.WriteLine($"First player wins! Sum: {first.Sum()}");
        else 
            Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
    }
}