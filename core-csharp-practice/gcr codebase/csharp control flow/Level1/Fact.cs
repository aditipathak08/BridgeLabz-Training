
 
 using System;

	class Fact
	{
		static void Main()
		{
		int a=int.Parse(Console.ReadLine());
		if(a < 0)
        {
            Console.WriteLine("Invalid");
            return; 
        }
		int f=1;
		int c=1;
		
		
		while(c<=a)
		{
			f=f*c;
		c++;
		}
		Console.WriteLine(f);
		
	}
	}
	