using System;
using System.Collections.Generic;
using System.Linq;

class Program 
{
    static void Main()
    {
        List<string> list = Console.ReadLine()
            .Split(' ').ToList();

        string line;
        while ((line = Console.ReadLine()) != "3:1")
        {
            string[] parts = line.Split(' ');
            string cmd = parts[0];

            if (cmd == "merge")
            {
                int start = int.Parse(parts[1]);
                int end = int.Parse(parts[2]);

                start = Math.Max(0, start);
                end = Math.Min(list.Count - 1, end);

                string merged = string.Concat(list.Skip(start).Take(end - start + 1));
                list[start] = merged;
                list.RemoveRange(start + 1, end - start);
            } 
            else if (cmd == "divide")
            {
                int index = int.Parse(parts[1]);
                int partitions = int.Parse(parts[2]);

                string word = list[index];
                int len = word.Length;
                int partSize = len / partitions;
                int remainder = len % partitions;

                List<string> divided = new List<string>();

                int pos = 0;
                for (int i = 0; i < partitions; i++)
                {
                    int size = (i == partitions - 1) ? partSize + remainder : partSize;
                    divided.Add(word.Substring(pos, size));
                    pos += size;
                }
                list.RemoveAt(index);
                list.InsertRange(index, divided);
            }
        }
        Console.WriteLine(string.Join(" ", list));
    }
}