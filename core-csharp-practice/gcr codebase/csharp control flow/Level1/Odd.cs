
using System;
class Odd
{
	static void Main()
	{
		int a=int.Parse(Console.ReadLine());
		for(int i=1;i<=a;i++)
		{
			if(i%2==0)
			{
				Console.WriteLine("even");
			}
			else 
			{
				
				Console.WriteLine("odd");
			}
		//Console.WriteLine(i);
		}
	}
}
		