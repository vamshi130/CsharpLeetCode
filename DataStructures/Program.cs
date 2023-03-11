using System;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins=new int[3] {2,6,12};
            int amount = 11;
            if (amount == 0)
            {
                Console.WriteLine(amount);
            }
            Array.Sort(coins);
            int[] dp = new int[amount + 1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;

            foreach (var coin in coins)
            {
                for (int i = coin; i <= amount; i++)
                {
                    if (dp[i - coin] != int.MaxValue)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }

            Console.WriteLine( dp[amount] == int.MaxValue ? -1 : dp[amount]);
        }
    }
}
