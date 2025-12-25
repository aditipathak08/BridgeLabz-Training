



using System;
class Small
{
	static void Checks(int number1, int number2, int number3,out int small,out int large)
	{
		small=number1;
		large=number2;
		if(number2<small)
		{
			small=number2;
		}
		else if(number3<small)
		{
			small=number3;
		}
		else if(number2>large)
		{
			large=number2;
		}
		else {
			large=number3;
		}
	}
	static void Main()
	{
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int number3=int.Parse(Console.ReadLine());
		int small;
		int large;
		Checks(number1,number2,number3,out small,out large);
		Console.WriteLine(small);
		Console.WriteLine(large);
	}
}
		
	
	