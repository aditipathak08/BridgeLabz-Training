using System;

class Contact
{
    private string FirstName;
    private string LastName;
    private string Address;
    private string City;
    private string State;
    private string Zip;
    private string Phone;
    private string Email;

    public Contact(string firstname, string lastname, string address,
                   string city, string state, string zip,
                   string phone, string email)
    {
        FirstName = firstname;
        LastName = lastname;
        Address = address;
        City = city;
        State = state;
        Zip = zip;
        Phone = phone;
        Email = email;
    }

    public string GetFirstName() { return FirstName; }
    public string GetLastName() { return LastName; }
    public string GetCity() { return City; }
    public string GetState() { return State; }
    public string GetZip() { return Zip; }

    public void Display()
    {
        Console.WriteLine("Name    : " + FirstName + " " + LastName);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("City    : " + City);
        Console.WriteLine("State   : " + State);
        Console.WriteLine("Zip     : " + Zip);
        Console.WriteLine("Phone   : " + Phone);
        Console.WriteLine("Email   : " + Email);
    }

    public bool Search(string keyword)
    {
        keyword = keyword.ToLower();
        return FirstName.ToLower().Contains(keyword) ||
               LastName.ToLower().Contains(keyword) ||
               City.ToLower().Contains(keyword) ||
               State.ToLower().Contains(keyword);
    }

    public void Edit()
    {
        Console.Write("Edit Address: ");
        Address = Console.ReadLine();

        Console.Write("Edit City: ");
        City = Console.ReadLine();

        Console.Write("Edit State: ");
        State = Console.ReadLine();

        Console.Write("Edit Zip: ");
        Zip = Console.ReadLine();

        Console.Write("Edit Phone: ");
        Phone = Console.ReadLine();

        Console.Write("Edit Email: ");
        Email = Console.ReadLine();

        Console.WriteLine("Contact updated successfully!");
    }

    public override bool Equals(object obj)
    {
        Contact other = obj as Contact;
        if (other == null) return false;

        return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
            && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return (FirstName + LastName).ToLower().GetHashCode();
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + ", " + City + ", " + State + ", " + Zip;
    }
}
