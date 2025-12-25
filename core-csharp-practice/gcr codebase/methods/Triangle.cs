

using System;
class Triangle
{
	static int rounds(int s1,int s2,int s3)
	{
		int p=s1+s2+s3;
		int d=5;
		int r=d/p;
		return r;
	}
	static void Main()
	{
		int s1=int.Parse(Console.ReadLine());
		int s2=int.Parse(Console.ReadLine());
		int s3=int.Parse(Console.ReadLine());
		int ro=rounds(s1,s2,s3);
		Console.WriteLine(ro);
	}
}
		
		
