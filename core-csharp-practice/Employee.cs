using System;

public class Employee
{
    private int empNo;
    private string empName;
    private double salary;
    private double hra, ta, da, pf, tds;
    private double grossSalary, netSalary;

    public void Accept(int eno, string name, double sal)
    {
        empNo = eno;
        empName = name;
        salary = sal;

        CalculateAllowances();
        CalculateSalary();
    }

    private void CalculateAllowances()
    {
        if (salary < 5000)
        {
            hra = salary * 0.10;
            ta  = salary * 0.05;
            da  = salary * 0.15;
        }
        else if (salary < 10000)
        {
            hra = salary * 0.15;
            ta  = salary * 0.10;
            da  = salary * 0.20;
        }
        else if (salary < 15000)
        {
            hra = salary * 0.20;
            ta  = salary * 0.15;
            da  = salary * 0.25;
        }
        else if (salary < 20000)
        {
            hra = salary * 0.25;
            ta  = salary * 0.20;
            da  = salary * 0.30;
        }
        else
        {
            hra = salary * 0.30;
            ta  = salary * 0.25;
            da  = salary * 0.35;
        }
    }

    private void CalculateSalary()
    {
        grossSalary = salary + hra + ta + da;
        pf  = salary * 0.10;
        tds = grossSalary * 0.05;
        netSalary = grossSalary - (pf + tds);
    }

    public void Display()
    {
        Console.WriteLine("Employee Salary Details");
        Console.WriteLine("Employee No   : " + empNo);
        Console.WriteLine("Employee Name : " + empName);
        Console.WriteLine("Basic Salary  : " + salary);
        Console.WriteLine("HRA           : " + hra);
        Console.WriteLine("TA            : " + ta);
        Console.WriteLine("DA            : " + da);
        Console.WriteLine("PF            : " + pf);
        Console.WriteLine("TDS           : " + tds);
        Console.WriteLine("Gross Salary  : " + grossSalary);
        Console.WriteLine("Net Salary    : " + netSalary);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee No: ");
        int eno = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        double sal = double.Parse(Console.ReadLine());
        emp.Accept(eno, name, sal);
        emp.Display();
    }
}
