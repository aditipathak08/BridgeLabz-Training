

using System;
class Natural
{
	static int Checks(int n)
	{
		int sum=0;
		for(int i=1;i<=n;i++)
		{
			sum=sum+i;
		}
			return sum;
		
	}
	static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		int res=Checks(n);
			Console.WriteLine(res);
	}
}
	
	
