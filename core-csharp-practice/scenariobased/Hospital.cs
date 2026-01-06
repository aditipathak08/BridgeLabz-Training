//Hospital Patient Management System
//● Concepts: Patient, Doctor, Bill classes.
//● OOP: Encapsulation(Properties), Abstraction(Interface IPayable), Inheritance
//(InPatient, OutPatient: Patient), Polymorphism(DisplayInfo).
using System;
interface Ipayable
{
	 double CalculateBill();
}
class Hospital
{
	static void Main()
	{
		Patient p = new Patient(101, "Aditi", 21);
		p.DisplayInfo();
	}



}
class Patient
{
	protected int PatientId;
	protected string Name;
	protected int Age;
	public Patient(int Id, string name, int age)
	{
		PatientId = Id;
		Name = name;
		Age = age;
	}
	public virtual void DisplayInfo()
	{
		Console.WriteLine(PatientId + " " + Name + " " + Age);

	}
}
class InPatient : Patient
{

	int RoomNumbers;
	int DaysAdmitted;
	public InPatient(int PatientId, string Name, int Age, int roomnumber,int days)
		:base(PatientId,Name,Age)
	{
		RoomNumbers = roomnumber;
		DaysAdmitted = days;
	}
	public override void DisplayInfo()
	{
		Console.WriteLine(PatientId + " " + Name +" " +Age+ " " + RoomNumbers +" " + DaysAdmitted);
	}

}
class Doctor
{
	int DoctorId;
	string DoctorName;
	string Specialization;
	public Doctor(int DoctorId,string DoctorName,string Specialization)
	{
		this.DoctorId = DoctorId;
		this.DoctorName = DoctorName;
		this.Specialization = Specialization;
	}
	public void Display()
	{
		Console.WriteLine(DoctorId +" " +  DoctorName + " " + Specialization);
	} 

}
class Bill : Ipayable
{
	double amount;
	public Bill(double amount)
	{
		this.amount = amount;
	}
	 double Ipayable.CalculateBill()
	{
		return amount;
	}


}