
using System;
class Earth{
	static void Main()
	{
		int r=6378 ;
		double kvol=(4.0/3)*3.14*r*r*r;
		double vol = kvol * Math.Pow(0.621371, 3);

		Console.WriteLine("The volume of earth in cubic kilometers is" + kvol +"and cubic miles is "+ vol );
	}
}