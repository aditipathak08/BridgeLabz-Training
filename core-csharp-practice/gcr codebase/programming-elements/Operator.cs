using System;
class Operator
{
	static void Main(){
		int a=int.Parse(Console.ReadLine());
		int b=int.Parse(Console.ReadLine());
		//Arithmetic Operator
		Console.WriteLine("Addition"+(a+b));
		Console.WriteLine("Subtraction"+(a-b));
		Console.WriteLine("Multiplication"+(a*b));
		Console.WriteLine("Division"+(a/b));
		Console.WriteLine("Modulus"+(a%b));
		//Relational Operator
		Console.WriteLine("Equals"+(a==b));
		Console.WriteLine("Not Equals"+(a!=b));
		Console.WriteLine("less than"+(a<b));
		Console.WriteLine("greater than"+(a>b));
		Console.WriteLine("less than equal to"+(a<=b));
		Console.WriteLine("greater than equal to"+(a>=b));
		bool c=int.Parse(Console.ReadLine());
		bool d=int.Parse(Console.ReadLine());
		
		//Logical Operator
		Console.WriteLine("and"+(c&&d));
		Console.WriteLine("or"+(c||d));
		Console.WriteLine("not"+(c!d));
		//Assignment Operator
		Console.WriteLine("Assignment "+(a=b));
		Console.WriteLine("Additional"+(a+=b));
		Console.WriteLine("Subtraction"+(a-=b));
		Console.WriteLine("Multiplication "+(a*=b));
		Console.WriteLine("Division"+(a/=b));
		Console.WriteLine("Modulos"+(a%=b));
		//Unary Operator
		Console.WriteLine("Unary Plus "+(a=b));
		Console.WriteLine("Unary Minus"+(a+=b));
		Console.WriteLine("Unary Increment"+(a++b));
		Console.WriteLine("Unary Decrement "+(a--b));
		Console.WriteLine("Unary Logical"+());
		//Ternary Operator
		Console.WriteLine("Ternary"+(a>b)?a:b));
		//int to double
		double b=a;
		Console.WriteLine("int to double" +b);