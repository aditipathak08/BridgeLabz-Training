

using System;
class Calc
{
	static int[] FindRemainderAndQuotient(int number, int divisor) 
	{
		int q=number/divisor;
		int r=number%divisor;
		return new int[] {q,r};
	}
	static void Main()
	{
		int number=int.Parse(Console.ReadLine());
		int divisor=int.Parse(Console.ReadLine());
		int [] result=FindRemainderAndQuotient(number,divisor);
		Console.WriteLine("Quotient = " + result[0]);
        Console.WriteLine("Remainder = " + result[1]);
	}
}
		