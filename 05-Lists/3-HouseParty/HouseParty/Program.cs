using System;
using System.Collections.Generic;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();
                string name = command.Split(' ')[0];

                if (command.Contains("not going"))
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
            }

            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}