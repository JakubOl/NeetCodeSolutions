using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class LongestSubstringRepeatingSolution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var chars = new List<char>();
            int res = 0;

            foreach(char c in s)
            {
                while (chars.Contains(c))
                {
                    chars = chars.Skip(1).ToList();
                }
                chars.Add(c);

                res = Math.Max(res, chars.Count());

            }

            return res;
        }
    }
}
