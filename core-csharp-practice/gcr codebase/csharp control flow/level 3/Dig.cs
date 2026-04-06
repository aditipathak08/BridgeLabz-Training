
 using System;
 class Dig
 {
 static void Main()
 {
	 int n=int.Parse(Console.ReadLine());
	 int count=0;
	 //int d=n;
	 while(n!=0)
	 {
		 n=n/10;
		 
		 count++;
	 }
	 Console.WriteLine(count);
 }
 }
 
		 
		 
 