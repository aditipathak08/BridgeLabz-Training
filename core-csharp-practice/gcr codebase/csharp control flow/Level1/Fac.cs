using System;
class Fac
{
static void Main()
{
	int fact=1;
	int n=int.Parse(Console.ReadLine());
	for(int i=1;i<=n;i++){
	fact=fact*i;
	Console.WriteLine(fact);
	}
}
}
	