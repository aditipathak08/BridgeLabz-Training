
using System;
class Natur
{
static void Main()
{
	int n = int.Parse(Console.ReadLine());
	int sum=0;
	int coun=1;
	if(n<=0)
	{
		return;
	}
	while(coun<=n)
	{
		sum=sum+coun;
		coun++;
	}
	int f=n*(n+1)/2;
	Console.Write(f);
	
	if(sum == f)
	{
            Console.WriteLine("correct!");
	}
        else
            Console.WriteLine("no!");
}
	
}
	