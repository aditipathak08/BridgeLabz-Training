using System;
class Triangle
{
	static void Main()
	{
		int b=int.Parse(Console.ReadLine());
		int height=int.Parse(Console.ReadLine());
		double a=0.5 * b * height;
		double inch=a/6.45164;
		double foot=inch/144;
		Console.Write("Your area in cm is "+ a + " while in feet is " + foot + "  and inches is "+ inch);
	}
}