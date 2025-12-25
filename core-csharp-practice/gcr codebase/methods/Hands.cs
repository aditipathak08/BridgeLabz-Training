using System;
class Hands
{
	static int students(int n)
	{
		int r=(n * (n - 1)) / 2;
		return r;
	}
	static void Main()
	{
		int n=int.Parse(Console.ReadLine());
		int k=students(n);
		Console.WriteLine(k);
	}
}