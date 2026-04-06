

using System;
class Children
{
	static void Main()
	{
		int children=int.Parse(Console.ReadLine());
		int chocolates=int.Parse(Console.ReadLine());
		int g=children/chocolates;
		int r=children%chocolates;
		Console.WriteLine("The number of chocolates each child gets is " + g + " and the number of remaining chocolates is " + r);
	}
}