// 5. Suppose you have to divide 14 pens among 3 students equally. Write a program to find how many pens each student will get
// if the pens must be divided equally. Also, find the remaining non-distributed pens.
//Hint:
//Use Modulus Operator (%) to find the reminder.
//Use Division Operator to find the Quantity of pens
//I/P => NONE
//O/P => The Pen Per Student is ___ and the remaining pen not distributed is ___
using System;
class Pens
{
static void Main()
{
	int p=14;
	int s=3;
	int student=p/s;
	Console.Write("The Pen Per Student is "+student);
	int undis=p%s;
	Console.Write("and the remaining pen not distributed is "+undis);
}

}
	
	