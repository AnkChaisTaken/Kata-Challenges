using System.Diagnostics;
using System.Text;

namespace KataChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encoding/Decoding Kata
            Console.WriteLine(RunLength.Encode("AAAABBBCCDAA"));

            // Subarray Sum
            Console.WriteLine(string.Join(',', SubarraySum.FindCoolContiguousElementsSumTo(new[] { 1, 2, 3, 4, 5 }, 9)));

            // Rotate a List by K Elements
            int[] sample = Enumerable.Range(1, 6).ToArray();
            ListRotator.RotateListByLeft(sample, 2);

            Console.WriteLine(string.Join(',', sample));

            // Reverse Integer
            Console.WriteLine(321.Reverse());
            Console.WriteLine(-120.Reverse());
            Console.WriteLine(2147483647.Reverse());
            Console.WriteLine(-2147483647.Reverse());
        }
    }
}
