using System.Diagnostics;
using System.Text;

namespace KataChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RunLength.Encode("AAAABBBCCDAA"));
            Console.WriteLine(string.Join(',', SubarraySum.FindCoolContiguousElementsSumTo(new[] { 1, 2, 3, 4, 5 }, 9)));

            List<int> sample = Enumerable.Range(1, 7).ToList();
            ListRotator.RotateListBy<int>(sample, 4);

            Console.WriteLine(string.Join(',', sample));
        }
    }
}
