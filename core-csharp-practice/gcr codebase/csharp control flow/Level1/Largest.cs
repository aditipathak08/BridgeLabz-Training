

using System;
class Largest
{
	static void Main()
	{
		int n1 =int.Parse(Console.ReadLine());
	 	 int n2=int.Parse(Console.ReadLine());
		 	 int n3=int.Parse(Console.ReadLine());
			 if((n1>n2)&&(n1>n3))
			 {
				 Console.WriteLine("Is the first number the largest? Yes ");
			 }
			 else if((n2>n1)&&(n2>n3))
			 {
				 
				 Console.WriteLine("Is the second number the largest? Yes ");
			 }
			 else{
				 Console.WriteLine("Is the third number the largest? Yes ");
			 }
			 
	  }
}