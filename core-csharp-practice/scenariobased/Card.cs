using System;
class Card
{
    static void Main()
    {
        Gateway [] gate=new Gateway[];
          point =0;
          Console.WriteLine("Enter Amount");
          Console.WriteLine("VIP");
          string typeofuser=Console.WriteLine();
    }
    while(true)
    {
        Console.WriteLine("Enter Payment");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Debit Card");
        Console.WriteLine("3. Online");
        Console.WriteLine("4. Cash");

        int n=Console.WriteLine("enter your option");
        switch(1)
        {
            case 1 : amount[point++] =amount.Payment(amount,typeofuser,"Credit Card");
            break;
            case 2 : amount[point++] =amount.Payment(amount,typeofuser,"Debit Card");
            break;
            case 3: amount [point++]=amount.Payment(amount,typeofuser,"Online");
            break;
            case 4 : amount[point++] =amount.Payment(amount,typeofuser,"Cash");
            break;
        }
    }
}
public class Gateway
{


    double amount;
    public double Payment(double amount,string typeofuser)
    {
        if(typeofuser== "Premium VIP")
        {
            Console.WriteLine("Account VIP : 20% off");
            Console.WriteLine(" amount to be paid"+(amount-(20/100)*amount));
            return (amount-(20/100)*amount); 
        }

else{
     Console.WriteLine(" amount to be paid"+(amount));
     return amount;
   }
    }
}