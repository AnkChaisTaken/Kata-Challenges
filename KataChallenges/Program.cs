using System.Diagnostics;
using System.Text;

namespace KataChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RunLength.Encode("AAAABBBCCDAA"));
            Console.WriteLine(string.Join(',', SubarraySum.FindCoolContiguousElementsSumTo(new[] { 1, 2, 3, 4, 5 }, 12)));
        }
    }
}
