using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public  class substring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            char[] temp = s.ToCharArray();
            int max = 0;
            Dictionary<char, int> collection = new Dictionary<char, int>();
            for (int i = 0, j = 0; i < temp.Length; i++)
            {
                if (collection.ContainsKey(temp[i]))
                {
                    j = Math.Max(j, collection[temp[i]] + 1);
                    collection.Remove(temp[i]);
                    collection.Add(temp[i], i);
                }
                else
                {
                    collection.Add(temp[i], i);
                }
                max = Math.Max(max, i - j + 1);
            }

            Console.WriteLine(collection.Count());
            return max;
        }
    }
}
