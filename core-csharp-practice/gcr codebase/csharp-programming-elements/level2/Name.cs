

using System;
class Name
{
static void Main()
{
	String name=Console.ReadLine();
		String fromCity=Console.ReadLine();
		String via=Console.ReadLine();
		String toCity=Console.ReadLine();
		int fromToVia=int.Parse(Console.ReadLine());
		int viaToFinalCity= int.Parse(Console.ReadLine());
		double time=double.Parse(Console.ReadLine());
		Console.WriteLine("The results of the trip are: " + name +"," + (fromToVia+viaToFinalCity)+ ", and " + time);
}
}
		
		