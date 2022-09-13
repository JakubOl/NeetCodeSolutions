using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class MinimumWindowSubstringSolution
    {
        public static string MinWindow(string s, string t)
        {
            if(t == "")
            {
                return "";
            }

            var countT = new Dictionary<char, int>();
            var window = new Dictionary<char, int>();


            foreach (char c in t)
            {
                if (countT.ContainsKey(c))
                {
                    countT[c]++;
                }
                else
                {
                    countT[c] = 1;
                }
            }

            var res = new int[] { -1, -1 };
            var resLength = s.Length;

            int have = 0;
            int need = countT.Count;
            int left = 0;

            for (int r = 0; r < s.Length; r++)
            {
                var c = s[r];
                if (window.ContainsKey(c))
                {
                    window[c]++;
                }
                else
                {
                    window[c] = 1;
                }

                if(countT.ContainsKey(c) && window[c].Equals(countT[c]))
                {
                    have++;
                }
                while (need == have)
                {
                    if((r - left + 1) < resLength)
                    {
                        res[0] = left;
                        res[1] = r;
                        resLength = (r - left + 1);
                    }
                    window[s[left]] -= 1;
                    if (countT.ContainsKey(s[left]) && window[s[left]] < countT[s[left]])
                    {
                        have--; 
                    }
                    left++;
                }
            }
            left = res[0];
            var right = res[1];
            if (!float.IsInfinity(resLength))
            {
                return s.Substring(left, right - left + 1);

            }
            else
            {
                return "";
            }
        }
    }
}
