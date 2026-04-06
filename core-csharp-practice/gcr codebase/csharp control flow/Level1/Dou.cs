


using System;
class Dou
{
	static void Main()
	{
		double total=0.0;
		double val=double.Parse(Console.ReadLine());
		while(val!=0.0)
		{
			total=total+val;
			Console.WriteLine("Enter Again");
			 val=double.Parse(Console.ReadLine());
		
	}
	Console.WriteLine(total);
	}
}