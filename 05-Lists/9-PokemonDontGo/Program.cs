using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<long> seq = Console.ReadLine().Split(' ')
                         .Select(long.Parse).ToList();
        long totalSum = 0;

        while (seq.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());

            // handle out of bounds
            if (index < 0)
            {
                long last = seq[seq.Count - 1];
                long removed = seq[0];
                seq.RemoveAt(0);
                seq.Insert(0, last);
                // apply changes
                ApplyChanges(seq, removed);
                totalSum += removed;
            }
            else if (index >= seq.Count)
            {
                long first = seq[0];
                long removed = seq[seq.Count - 1];
                seq.RemoveAt(seq.Count - 1);
                seq.Add(first);
                ApplyChanges(seq, removed);
                totalSum += removed;
            }
            else
            {
                long removed = seq[index];
                seq.RemoveAt(index);
                ApplyChanges(seq, removed);
                totalSum += removed;
            }
        }

        Console.WriteLine(totalSum);
    }

    static void ApplyChanges(List<long> seq, long removed)
    {
        for (int i = 0; i < seq.Count; i++)
        {
            if (seq[i] <= removed)
                seq[i] += removed;
            else
                seq[i] -= removed;
        }
    }
}