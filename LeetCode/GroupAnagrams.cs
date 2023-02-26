using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    public class GroupAnagrams
    {
       public static IList<IList<string>> GroupAnagram()
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Dictionary<string, List<string>> containsString = new Dictionary<string, List<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                char[] ch = strs[i].ToCharArray();
                Array.Sort(ch);
                string updateString = new string(ch);
                if (!containsString.ContainsKey(updateString))
                {
                    containsString.Add(updateString, new List<string> { strs[i]});
                }
                else
                {
                    containsString[updateString].Add(strs[i]);
                }
            }
            Console.WriteLine(containsString.Values.ToArray());
            return containsString.Values.ToArray();
        }
    }
}
