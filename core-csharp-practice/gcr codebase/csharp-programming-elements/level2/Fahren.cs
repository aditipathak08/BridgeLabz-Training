
using System;
class Fahren
{
static void Main()
{
	Console.Write("enter temperature ");
	int f=int.Parse(Console.ReadLine());
	double c=(f-32)*(5.0/9);
	Console.WriteLine("The " + c + " Fahrenheit is " + f + "Celsius");
}
} 
	

