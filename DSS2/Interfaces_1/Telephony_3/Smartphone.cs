using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Telephony_3
{
    public class Smartphone
    {
        public void Call(string phoneNumber)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }
            Console.WriteLine("Calling... {phoneNumber}");
        }
        public void Browse(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }
            Console.WriteLine($"Calling... {phoneNumber}");
        }
        public void Browse(string url)
        {
            if (!Helpers.IsPhoneValid(url))
            {

            }
        }
    }
}
