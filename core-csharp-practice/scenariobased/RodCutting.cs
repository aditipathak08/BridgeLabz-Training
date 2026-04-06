using System;

class RodCutting
{
    static int MaxRevenue(int[] price, int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 0;

        for (int i = 1; i <= n; i++)
        {
            int max = int.MinValue;
            for (int j = 1; j <= i; j++)
            {
                max = Math.Max(max, price[j] + dp[i - j]);
            }
            dp[i] = max;
        }
        return dp[n];
    }

    static void Main()
    {
        // Scenario A
        int[] price = { 0, 1, 5, 8, 9, 10, 17, 17, 20 };
        int rodLength = 8;

        Console.WriteLine("Max Revenue (Scenario A): " + MaxRevenue(price, rodLength));

        // Scenario B: Custom length price added (length 3 → 12)
        price[3] = 12;
        Console.WriteLine("Max Revenue (Scenario B): " + MaxRevenue(price, rodLength));

        // Scenario C: Non-optimized (equal cut)
        int nonOptimized = price[4] + price[4];
        Console.WriteLine("Non-Optimized Revenue (Scenario C): " + nonOptimized);
    }
}

