using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            string[] parts = line.Split(' ');
            string cmd = parts[0];

            if (cmd == "Delete")
            {
                int element = int.Parse(parts[1]);
                list.RemoveAll(x => x == element);
            } else if (cmd == "Insert")
            {
                int element = int.Parse(parts[1]);
                int position = int.Parse(parts[2]);
                list.Insert(position, element);
            }
        }
        Console.WriteLine(string.Join(" ", list));
    }
}