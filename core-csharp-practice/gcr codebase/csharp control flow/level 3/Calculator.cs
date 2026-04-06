using System;

class Calculator
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();

        switch(op)
        {
            case "+":
                Console.WriteLine(first + second);
                break;
            case "-":
                Console.WriteLine(first - second);
                break;
            case "*":
                Console.WriteLine(first * second);
                break;
            case "/":
                if(second != 0)
                    Console.WriteLine(first / second);
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
