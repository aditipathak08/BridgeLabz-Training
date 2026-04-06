using System;
class Calculator
{
	static void Main()
	{
		float a=float.Parse(Console.ReadLine());
		float b=float.Parse(Console.ReadLine());
		float add=a+b;
		float sub=a-b;
		float mul=a*b;
		float div=a/b;
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers is " + add  +"," +sub + "," + mul + "," +div);
		
		
	}
}