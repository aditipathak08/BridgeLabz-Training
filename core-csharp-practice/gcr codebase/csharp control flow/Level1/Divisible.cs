
 using System;
 class Divisible
 {
 static void Main()
 {
	 int n=int.Parse(Console.ReadLine());
	 if(n%5==0)
	 {
		 Console.WriteLine("Is the number " + n + " divisible by 5 ?" + "Yes");
	 }
	 else{
		 Console.WriteLine("Is the number " + n + " divisible by 5 ?" + "No");
	 }
 }
 }