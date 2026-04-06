using System;

class Card
{
static void Main()
    {
    Gateway gateway = new Gateway();

     Console.WriteLine("Enter Amount:");
    double amount = double.Parse(Console.ReadLine());

     Console.WriteLine("Enter User Type (VIP / Normal):");
        string typeofuser = Console.ReadLine();

        while (true)
        {
            Console.WriteLine(" Enter Payment Method:");
               Console.WriteLine("Enter 1 for Credit Card");
                Console.WriteLine("Enter 2 for Debit Card");
            Console.WriteLine("Enter 3 for Online");
               Console.WriteLine("Enter 4 for Cash");
               Console.WriteLine("Enter 5 to Exit");
 int choice = int.Parse(Console.ReadLine());

    if (choice == 5)
                break;

 switch (choice)
            {
                case 1:
    gateway.Payment(amount, typeofuser, "Credit Card");
        break;

               case 2:
                    gateway.Payment(amount, typeofuser, "Debit Card");
                    break;

                case 3:
                              gateway.Payment(amount, typeofuser, "Online");
                    break;

                case 4:
                    gateway.Payment(amount, typeofuser, "Cash");
                    break;
                default:
           Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}

public class Gateway
{
    public double Payment(double amount, string typeofuser, string method)
    {
        Console.WriteLine("Payment Method"+method);

                if (typeofuser.Equals("VIP", StringComparison.OrdinalIgnoreCase))
            {           //vip user to get 20 percent off
                    double discount = amount * 0.20;
                  double finalAmount = amount - discount;

            Console.WriteLine("Account VIP: 20% off");
      Console.WriteLine("Amount to be paid: " + finalAmount);
            return finalAmount;
        }
                else
        {
              Console.WriteLine("Amount to be paid: " + amount);
            return amount;
        }6 +3
    }
}
