
using System;
class Prime
{
	static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		int count=0;
		for(int i=2;i<=n;i++)
		{
			if(n%i==0)
			{ count ++;
				
			}
		}
			
			if(count>=1)
			{
				Console.WriteLine("not prime");
			}
			else{
				Console.WriteLine("prime");
			}
		}
	}
	