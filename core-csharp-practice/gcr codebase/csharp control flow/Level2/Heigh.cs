
using System;
class Heigh
{
	static void Main()
	{
	double age1=double.Parse(Console.ReadLine());
	double height1=double.Parse(Console.ReadLine());
	double age2=double.Parse(Console.ReadLine());
	double height2=double.Parse(Console.ReadLine());
	double age3=double.Parse(Console.ReadLine());
	double height3=double.Parse(Console.ReadLine());
	if(age1<age2&&age1<age3)
	{
		Console.WriteLine("Amar is youngest");
	}
	else if(age2<age1&&age2<age3)
	{
		Console.WriteLine("Akbar is youngest");
	}
	else 
	{
		Console.WriteLine("Anthony is youngest");
	}
	if(height1>height2&&height1>height3)
	{
		Console.WriteLine("Amar is tallest");
	}
	else if(height2>height1&&height2>height3)
	{
		Console.WriteLine("Akbar is tallest");
	} 
	else{
		Console.WriteLine("Anthonny is tallest");
	}
	}
}
	