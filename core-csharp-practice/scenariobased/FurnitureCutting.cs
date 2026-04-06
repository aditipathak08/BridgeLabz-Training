using System;

class FurnitureCutting
{
    static (int revenue, int waste) MaxRevenueWithWaste(int[] price, int rodLength, int maxWaste)
    {
        (int revenue, int waste)[] dp = new (int, int)[rodLength + 1];
        dp[0] = (0, 0);

        for (int i = 1; i <= rodLength; i++)
        {
            dp[i] = (0, i); // default waste = full length
            for (int j = 1; j <= i; j++)
            {
                int rem = i - j;
                int revenue = price[j] + dp[rem].revenue;
                int waste = dp[rem].waste;

                if (waste <= maxWaste)
                {
                    if (revenue > dp[i].revenue ||
                       (revenue == dp[i].revenue && waste < dp[i].waste))
                    {
                        dp[i] = (revenue, waste);
                    }
                }
            }
        }
        return dp[rodLength];
    }

    static void Main()
    {
        int[] price = { 0, 2, 6, 9, 12, 15, 30, 32, 35, 40, 45, 50, 55 };
        int rodLength = 12;
        int maxWaste = 1;

        var result = MaxRevenueWithWaste(price, rodLength, maxWaste);

        Console.WriteLine("Max Revenue: " + result.revenue);
        Console.WriteLine("Waste: " + result.waste + " ft");
    }
}
