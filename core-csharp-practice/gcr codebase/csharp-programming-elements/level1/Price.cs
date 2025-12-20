


using System;
class Price
{ static void Main()
	{
		int u_p=int.Parse(Console.ReadLine());
		int quan=int.Parse(Console.ReadLine());
	    int t_p=u_p*quan;
		Console.WriteLine(" The total purchase price is INR " + t_p + " if the quantity " + quan + " and unit price is INR " +u_p);


	}
}