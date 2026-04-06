
using System;
class Season
{
static void Main()

{
int month=int.Parse(Console.ReadLine());
int day=int.Parse(Console.ReadLine());
	if(month>=3&&month<=6&&day>=20)
	{
		Console.WriteLine("Its a Spring Season");
	}
	else{
		Console.WriteLine("Its not a Spring Season");
	}
}
}
