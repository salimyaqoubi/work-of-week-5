using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day18
{
    internal static class IntegerMirror
    {
        public static int Mirror(this int Number)
        {
            int result = 0, reminder;
            while (Number != 0)
            {
                reminder = Number % 10;
                result = result * 10 + reminder;
                Number = Number / 10;

            }
            return result;

        }
       
    }
}
