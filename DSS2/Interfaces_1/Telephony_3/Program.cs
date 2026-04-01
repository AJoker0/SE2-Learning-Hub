using System.ComponentModel;

namespace Telephony_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine().Split(' ');
            string[] websites = Console.ReadLine.Split(' ');
            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            for (int = 0; int < phones.Length; int++)
            {
                if (phones[int].Length == 7)
                {
                    stationaryPhone.Call(phones[int]);
                    continue;
                }
                smartphone.Call(phones[int]);
            }
            for (int i = 0; i < websites.Length; i++)
            {
                smartphone.Browse(websites[i]);
            }
            
        }
    }
}
