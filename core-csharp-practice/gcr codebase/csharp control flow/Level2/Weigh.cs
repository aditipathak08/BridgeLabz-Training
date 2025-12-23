
using System;
class Weigh
{
	static void Main()
	{
	double weight=double.Parse(Console.ReadLine());
	double height=double.Parse(Console.ReadLine());
	double bmi = weight*100 / (height * height);
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
	
	