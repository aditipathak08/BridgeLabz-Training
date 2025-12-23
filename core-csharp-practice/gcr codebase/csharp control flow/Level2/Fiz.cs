
using System;
class Fiz
{
	static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		if(n>0)
		{
			for(int i=0;i<=n;i++)
			{
		     if(i%3==0&&i%5==0)
		 {
			 Console.WriteLine("FizzBuzz");
		 }
		 else if(i%5==0)
		 {
			 Console.WriteLine("Buzz");
		 }
		  else if(i%3==0)
		 { 
	 Console.WriteLine("Fizz");
		 }
			 else
			 {
				 Console.WriteLine(i);
			 }
			}
		}
	}
}
		