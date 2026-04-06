using System;
class ProfitLoss
{
	static void Main()
	{
		int c=129;
		int s=191;
		int profit=(s-c);
		double per=(((double)profit/c)*100);
		Console.Write("The Cost Price is INR "+ c);
		Console.WriteLine("The Selling Price is INR "+ s);
		Console.Write("The profit is INR " + profit);
		Console.Write("The Profit Percentage is " + per);
	}
}