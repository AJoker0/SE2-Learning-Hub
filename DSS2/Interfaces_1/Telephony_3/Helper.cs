using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony_3
{
    internal class Helper
    {
        public static bool IsPhoneValid(string url)
        => !url.Any(c => char.IsDigit(c));
    }
}
