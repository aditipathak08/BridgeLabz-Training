

class Swap{
	static void Main()
	{
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int c=number2;
		number2=number1;
		number1= c;
		Console.WriteLine("The swapped numbers are " +number1 + " and" + number2);
	}
}