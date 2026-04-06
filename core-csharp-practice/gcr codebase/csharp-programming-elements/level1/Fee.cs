
using System;
class Fees
{
	static void Main()
	{
		double f =125000.0;
		int dp=10;
		double da=f/dp;
		double dis=f-da;
		Console.Write("The discount amount is INR "+da);
		Console.WriteLine(" and final discounted fee is INR "+dis);
		
	}
}