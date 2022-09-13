using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class LongestRepeatingCharacterReplacemnetSolution
    {
        public static int CharacterReplacement(string s, int k)
        {
            int l = 0;
            var counts = new Dictionary<char, int>();
            int max = 0;

            for(int r=0 ; r< s.Length; r++)
            {

                if (counts.ContainsKey(s[r]))
                {
                    counts[s[r]]++;
                }
                else
                {
                    counts[s[r]] = 1;
                }

                while(r - l + 1 - counts.Values.Max() > k)
                {
                    counts[s[l]]--;
                    l++;
                }
                max = Math.Max(max, r - l + 1);
            }
            return max;
        }
    }
}
