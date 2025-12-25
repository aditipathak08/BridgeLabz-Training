

using System;
class Season
{
static bool Check(int month,int day)
{
if(month>=3&&month<=3&day>=20&&day<=20)
{
	return true;
}
else{
	return false;
}
}
static void Main()
{
	int month=int.Parse(Console.ReadLine());
	int day=int.Parse(Console.ReadLine());
	bool res=Check(month,day);
	if(res==true)
	{
		Console.WriteLine("Its a Spring Season");
	}
	else
	{
		Console.WriteLine("Not a Spring Season");
	}
}}
		
	
