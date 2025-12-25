


using System;
class Numb{
	static int Pro(int n)
	{
		if(n>1)
		{
			return 1;
		}
		else if(n<1)
		{
			return -1;
		}
		else
		{
			return 0;
	}
	}
	static void Main()
	{
	int n=int.Parse(Console.ReadLine());
	int r=Pro(n);
	if(r==1)
	{
		Console.WriteLine("positive");
	}
	else if(r==0)
	{
		Console.WriteLine("negative");
	}
	else{
		Console.WriteLine("zero");
	}
	}
}