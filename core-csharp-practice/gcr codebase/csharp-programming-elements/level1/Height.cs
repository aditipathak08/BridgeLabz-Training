using System;
class Height
{
	static void Main()
	{
		double h=double.Parse(Console.ReadLine());
		
		double inch=h/2.54;
		double foot=inch/12;
		Console.Write(" Your Height in cm is " +h + " while in feet is "+foot +" and inches is "+inch);
	}
}