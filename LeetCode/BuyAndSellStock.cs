using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
     static internal class BuyAndSellStock
    {
        public static int SellStock()
        {
            int[] prices = new int[] { 7, 2, 4, 1, 5, 6, 4 };
            int max = 0;
            int n = prices.Length;
            int buy = prices[0];
            for(int i = 0; i < n; i++)
            {
                if(buy> prices[i])
                {
                    buy= prices[i];
                }
                else if (prices[i]-buy > max)
                {
                    max = prices[i] - buy;
                }
            }
            //for (int i= 0;i < prices.Length-1;i++)
            //{
            //    for(int j = i + 1; j < prices.Length; j++)
            //    {
            //        if (prices[j] - prices[i] > max)
            //        {
            //            max= prices[j] - prices[i];
            //        }
            //    }
            //}
            Console.WriteLine(max);
            return max;
        }
    }
}
