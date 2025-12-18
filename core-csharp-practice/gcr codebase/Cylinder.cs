using System;
class Cylinder
{
	static void Main()
	{
		Console.Write("enter radius");
		int r=int.Parse(Console.ReadLine());
		Console.Write("enter height");
		int h=int.Parse(Console.ReadLine());
		double a=(3.14*r*r*h);
		Console.WriteLine(a);
	}
}
		
		