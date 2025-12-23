
using System;
class Weig
{
	static void Main()
	{
	double w=double.Parse(Console.ReadLine());
	double h=double.Parse(Console.ReadLine());
	duble bmi = weight*100 / (height * height);
	if (bmi<=18.4)
	{
		Console.WriteLine("Underweight");
	}
	else if(bmi>18.5&&bmi<=24.9)
	{
		Console.WriteLine("Normal");
	}
	else if(bmi>25&&bmi<39.9)
	{
		Console.WriteLine("Overweight");
	}
	else if(bmi>=40)
	{
		Console.WriteLine("obese");
	}
	}
}
	
	