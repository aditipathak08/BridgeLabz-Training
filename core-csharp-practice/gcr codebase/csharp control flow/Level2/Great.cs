
 
 using System;
class Great
{
	static void Main()
	{
		int number=int.Parse(Console.ReadLine());
		int greatest=1;
		for(int i=1;i<number;i++)
		{
			if(number%i==0)
			{
				//Console.WriteLine(i);
				greatest=i;
			}
		}
			Console.WriteLine(greatest);
			
		}
	}
