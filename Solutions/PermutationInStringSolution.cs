using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions.Solutions
{
    public static class PermutationInStringSolution
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            if(s1.Length > s2.Length) return false;

            var s1Count = new int[26];
            var s2Count = new int[26];

            Array.Fill(s1Count, 0);
            Array.Fill(s2Count, 0);

            for (int i = 0; i < s1.Length; i++)
            {
                s1Count[(int)s1[i] - (int)'a'] += 1;
                s2Count[(int)s2[i] - (int)'a'] += 1;
            }
            var matches = 0;

            for (int i = 0; i < 26; i++)
            {
                matches += s1Count[i] == s2Count[i] ? 1 : 0;
            }

            var l = 0;

            for (int r = s1.Length; r < s2.Length; r++)
            {
                if (matches == 26) return true;

                var index = (int)s2[r] - (int)'a';
                s2Count[index] += 1;
                if(s1Count[index] == s2Count[index])
                {
                    matches++;
                }else if (s1Count[index] + 1 == s2Count[index])
                {
                    matches--;
                }

                var indexL = (int)s2[l] - (int)'a';
                s2Count[indexL] -= 1;
                if (s1Count[indexL] == s2Count[indexL])
                {
                    matches++;
                }
                else if (s1Count[indexL] - 1 == s2Count[indexL])
                {
                    matches--;
                }
                l++;
            }

            return matches == 26;
        }
    }
}
