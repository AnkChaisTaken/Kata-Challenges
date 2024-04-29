using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataChallenges
{
    public static class RunLength
    {
        public static string Encode(string rawText)
        {
            List<(char, int)> chars = new List<(char, int)>();

            char currentChar = rawText[0];
            int currentCount = 1;

            for (int i = 1; i < rawText.Length; i++)
            {
                if (currentChar != rawText[i])
                {
                    chars.Add((currentChar, currentCount));

                    currentChar = rawText[i];
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }
            }
            chars.Add((currentChar, currentCount));

            StringBuilder encodedText = new StringBuilder();
            foreach (var charGroup in chars)
            {
                encodedText.Append($"{charGroup.Item2}{charGroup.Item1}");
            }

            return encodedText.ToString();
        }

        public static string Decode(string encodedText)
        {
            StringBuilder decodedText = new StringBuilder();

            int count = 0;
            for (int i = 0; i < encodedText.Length; i++)
            {
                char c = encodedText[i];

                if (char.IsDigit(c))
                {
                    count = count * 10 + (c - '0');
                }
                else
                {
                    decodedText.Append(new string(c, count));
                }
            }

            return decodedText.ToString();
        }
    }
}
