
using System;
class Sal
{
	static void Main()
	{
		int s=int.Parse(Console.ReadLine());
		int y=int.Parse(Console.ReadLine());
		if(y>=5)
		{
			double bonus=(s+(5.0/100*s));
			Console.WriteLine(bonus);
		}
		else
		{
			Console.WriteLine("no bonus " +s);
		}
	}
}
			
		