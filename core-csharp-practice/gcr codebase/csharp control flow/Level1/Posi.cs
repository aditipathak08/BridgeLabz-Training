

using System;
class Posi
{
	static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		if(n>0)
		{
			Console.WriteLine("positive");
	}
	else if(n<0)
	{
		Console.WriteLine("negative");
	}
	else{
		Console.WriteLine("zero");
	}
	}
}