using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataChallenges
{
    public static class ReverseInteger
    {
        public static int Reverse(this int x)
        {
            int sign = Math.Sign(x);
            x = Math.Abs(x);

            int number = 0;

            while (x > 0)
            {
                var digit = x % 10;
                x /= 10;

                try
                {
                    number = checked((number * 10) + digit);
                } catch (OverflowException e)
                {
                    return 0;
                }
            }

            return number * sign;
        }
    }
}
