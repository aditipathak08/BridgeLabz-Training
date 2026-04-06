  
  using System;
  class Sum
  {
  static void Main()
  {
	  int n=int.Parse(Console.ReadLine());
	  int s=0;
	  if(n>0)
	  {
		   s = n * (n+1) / 2 ;
		  
		  Console.WriteLine("The sum of " +n + " natural numbers is " +s );
	  }
	  else{
		  Console.WriteLine("The number  " +n + " is not a natural number" );
	  }
  }
  }