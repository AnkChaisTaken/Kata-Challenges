using System;
using System.Collections.Generic;
using System.Diagnostics;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataChallenges
{
    public static class ListRotator
    {
        public static void RotateListByLeft<T>(T[] list, int k)
        {
            var original = new List<T>(list);

            for (int i = 0; i < list.Length; i++)
            {
                int offset = (i - k + list.Length) % list.Length;

                T originalValue = original[i];
                list[offset] = originalValue;
            }
        }
    }
}
