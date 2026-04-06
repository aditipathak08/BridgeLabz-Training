

using System;
class Athlete
{
	static void Main()
	{ 
	  //  int s=int.Parse(Console.ReadLine());
		int s1=int.Parse(Console.ReadLine());
		int s2=int.Parse(Console.ReadLine());
		int s3=int.Parse(Console.ReadLine());
		int d=5000;
		int p=(s1+s2+s3);
		double rounds=d/p;
		Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
		
	}
}