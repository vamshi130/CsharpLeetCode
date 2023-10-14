using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class TimeBasedKeyValueStore
    {
        private IDictionary<string, List<(string,int)>> _dict; 
        public TimeBasedKeyValueStore()
        {
            _dict = new Dictionary<string, List<(string, int)>>();
        }
        public void set(string key, string value, int timestamp)
        {
            if( !(_dict.ContainsKey(key)) )
            {
                _dict[key]  = new List<(string, int)>();
            }
            _dict[key].Add((value, timestamp));
        }
    }
}
