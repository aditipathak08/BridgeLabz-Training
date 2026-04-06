

using System;
class Arm 
{
static void Main()
{
int n=int.Parse(Console.ReadLine());
int s=0;
int og=n;
while(og!=0)
{
	int r=og%10;
	int c=r*r*r;
	s=s+c;
	og=og/10;
	if(n==s)
	{
		Console.WriteLine("armstrong");
	}
		else{
			Console.WriteLine("not an armstrong");
		}
	}
}

}
	