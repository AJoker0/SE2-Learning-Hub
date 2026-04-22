using System;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] field = new int[size];

        //place inital ladybugs
        string[] indexes = Console.ReadLine().Split(' ');
        foreach (string idx in indexes)
        {
            int pos = int.Parse(idx);
            if (pos >= 0 && pos < size)
                field[pos] = 1;
        }
        string line;
        while ((line = Console.ReadLine()) != "end")
        {
            string[] parts = line.Split(' ');
            int bugIndex = int.Parse(parts[0]);
            string dir = parts[1];
            int flyLength = int.Parse(parts[2]);

            // no ladybug the or outside field -> skip
            if (bugIndex < 0 || bugIndex >= size || field[bugIndex] == 0)
                continue;

            int step = dir == "right" ? flyLength : -flyLength;

            //remove from current position
            field[bugIndex] = 0;
            int newPos = bugIndex + step;

            //keep jumping if landing on another ladybug
            while (newPos >= 0 && newPos < size && field[newPos] == 1)
                newPos += step;

            //place only if still inside field
            if (newPos >= 0 && newPos < size) field[newPos] = 1;

        }
        Console.WriteLine(string.Join(" ", field));
    }
}