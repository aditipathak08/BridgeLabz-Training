


using System;
class Multi
{
	static void Main()
	{
		int a=int.Parse(Console.ReadLine());
		for(int i=100;i>=1;i--)
		{
			if(i%a==0)
			{
				Console.WriteLine(i);
			}
		}
	}
}
			
		