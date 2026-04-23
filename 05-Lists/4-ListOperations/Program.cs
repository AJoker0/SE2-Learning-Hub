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
        while ((line = Console.ReadLine()) != "End")
        {
            string[] parts = line.Split(' ');
            string cmd = parts[0];

            if (cmd == "Add")
            {
                list.Add(int.Parse(parts[1]));
            }
            else if (cmd == "Insert")
            {
                int number = int.Parse(parts[1]);
                int index = int.Parse(parts[2]);

                if (index < 0 || index >= list.Count)
                    Console.WriteLine("Invalid index");
                else
                    list.Insert(index, number);
            }
            else if (cmd == "Remove")
            {
                int index = int.Parse(parts[1]);

                if (index < 0 || index >= list.Count)
                    Console.WriteLine("Invalid index");
                else
                    list.RemoveAt(index);
            }
            else if (cmd == "Shift")
            {
                string direction = parts[1];
                int count = int.Parse(parts[2]);

                count = count % list.Count; // optimize

                for (int i = 0; i < count; i++)
                {
                    if (direction == "left")
                    {
                        int first = list[0];
                        list.RemoveAt(0);
                        list.Add(first);
                    }
                    else // right
                    {
                        int last = list[list.Count - 1];
                        list.RemoveAt(list.Count - 1);
                        list.Insert(0, last);
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", list));
    }
}