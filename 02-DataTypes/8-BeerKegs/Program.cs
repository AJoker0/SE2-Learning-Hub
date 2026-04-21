using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string biggestModel = "";
        double biggestVolume = -1;

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume= Math.PI * radius * radius * height;

            if (volume > biggestVolume)
            {
            biggestVolume = biggestVolume;
            biggestModel = model;
            }

        }
        Console.WriteLine(biggestModel);

    }
}