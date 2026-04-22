using System;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        int bestIndex = -1;
        int bestOnesLength = -1;
        int bestStartIndex = -1;
        int bestSum = -1;
        int[] bestSequence = null;

        int seqIndex = 0;
        string line;

        while ((line = Console.ReadLine()) != "Clone them!")
        {
            seqIndex++;
            int[] dna = Array.ConvertAll(line.Split('!'), int.Parse);

            // find longest subsequence 
            int currOnes = 0;
            int maxOnes = 0;
            int startIndex = 0;
            int tempStart = 0;

            for (int  i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 1)
                {
                    currOnes++;
                    if (currOnes > maxOnes)
                    {
                        maxOnes = currOnes;
                        startIndex = tempStart;
                    }
                }
                else
                {
                    currOnes++;
                    tempStart = i + 1;
                }
            }
            int sum = 0;
            foreach (int x in dna) sum += x;

            //compare with best
            if (maxOnes > bestIndexOnesLength ||
                maxOnes == bestOnesLength && startIndex < bestStartIndex ||
                maxOnes == bestOnesLength && startIndex == bestStartIndex && sum > bestSum)
            {
                bestIbdex = seqIndex;
                bestOnesLength = maxOnes;
                bestStartIndex = startIndex;
                bestSum = sum;
                bestSequence = dna;
            }
        }
        Console.WriteLine($"Best DNA sample {bestIndex} with sum: {bestSum}.");
        Console.WriteLine(string.Join(" ", bestSequence));
    }
}