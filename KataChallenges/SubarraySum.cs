using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataChallenges
{
    public static class SubarraySum
    {
        public static int[] FindContiguousElementsSumTo(int[] numbers, int k)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                int index = i;

                while (index < numbers.Length - i && sum < k)
                {
                    sum += numbers[index];
                    index++;
                }

                if (sum == k)
                    return numbers.Skip(i).Take(index - i).ToArray();
            }

            return Array.Empty<int>();
        }
    }
}
