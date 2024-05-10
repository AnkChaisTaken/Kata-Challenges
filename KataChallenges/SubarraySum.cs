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

        // 1. hepsini al ve sağdan ve soldan çıkar
        // 2. soldan başla ve yavaşça ilerle

        public static int[] FindCoolContiguousElementsSumTo(int[] numbers, int k)
        {
            int startIndex = 0;
            int startNum = numbers[0];

            int sum = 0;

            for (int endIndex = 0; endIndex < numbers.Length; endIndex++)
            {
                int endNum = numbers[endIndex];
                sum += endNum;
                
                while (sum > k)
                {
                    sum -= startNum;

                    startIndex++;
                    startNum = numbers[startIndex];
                }

                if (sum == k)
                    return numbers.Skip(startIndex).Take(endIndex + 1 - startIndex).ToArray();
            }

            return Array.Empty<int>();
        }
    }
}
