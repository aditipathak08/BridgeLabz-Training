using System;
class UserFee
{
	static void Main()
	{
		int f =int.Parse(Console.ReadLine());
		int dp=int.Parse(Console.ReadLine());
		double da=(double)f*dp/100;
		double dis=f-da;
		Console.Write("The discount amount is INR "+da);
		Console.WriteLine(" and final discounted fee is INR "+dis);
		
	}
}