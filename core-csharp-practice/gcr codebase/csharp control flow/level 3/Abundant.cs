
using System;
class Abundant
{
	static void Main()
	{
		int number=int.Parse(Console.ReadLine());
		int s=0;
		for(int i=1;i<number;i++)
		{
			if(number%i==0)
			{
				s=s+i;
			}
			}
			if(s>number)
			{
				Console.WriteLine("Abundant");
			}
			else{
				Console.WriteLine("Not an Abundant");
			}
		}
	
}