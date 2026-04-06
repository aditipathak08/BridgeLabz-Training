using System;
class SI
{
	static void Main(){
		Console.Write("enter principal");
		int p=int.Parse(Console.ReadLine());
		Console.Write("enter rate");
		int r=int.Parse(Console.ReadLine());
		Console.Write("enter time");
		int t=int.Parse(Console.ReadLine());
		double si=(p*r*t)/100;
		Console.WriteLine(si);
	}
}

		
		
		