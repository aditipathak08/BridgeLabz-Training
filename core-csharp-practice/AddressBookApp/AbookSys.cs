using System;

class AbookSys : IAddressBookSystem
{
    private string[] bookNames;
    private AdBook[] addressBooks;
    private int count;

    // ✅ Constructor name fixed
    public AbookSys()
    {
        bookNames = new string[2];
        addressBooks = new AdBook[2];
        count = 0;
    }

    // UC 5: Add new Address Book
    public void AddAddressBook(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }
        }

        if (count == bookNames.Length)
        {
            string[] newNames = new string[bookNames.Length + 1];
            AdBook[] newBooks = new AdBook[addressBooks.Length + 1];

            for (int i = 0; i < count; i++)
            {
                newNames[i] = bookNames[i];
                newBooks[i] = addressBooks[i];
            }

            bookNames = newNames;
            addressBooks = newBooks;
        }

        bookNames[count] = name;
        addressBooks[count] = new AdBook();
        count++;

        Console.WriteLine("Address Book added successfully!");
    }

    // Get address book by name
    public AdBook GetAddressBook(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                return addressBooks[i];
        }
        return null;
    }

    // UC 8: Search by city across books
    public Contact[] SearchByCityAcrossBooks(string city)
    {
        Contact[] result = new Contact[50];
        int index = 0;

        for (int i = 0; i < count; i++)
        {
            Contact[] persons = addressBooks[i].GetPersonsByCity(city);
            for (int j = 0; j < persons.Length; j++)
                result[index++] = persons[j];
        }

        Contact[] finalResult = new Contact[index];
        for (int i = 0; i < index; i++)
            finalResult[i] = result[i];

        return finalResult;
    }

    // UC 8: Search by state across books
    public Contact[] SearchByStateAcrossBooks(string state)
    {
        Contact[] result = new Contact[50];
        int index = 0;

        for (int i = 0; i < count; i++)
        {
            Contact[] persons = addressBooks[i].GetPersonsByState(state);
            for (int j = 0; j < persons.Length; j++)
                result[index++] = persons[j];
        }

        Contact[] finalResult = new Contact[index];
        for (int i = 0; i < index; i++)
            finalResult[i] = result[i];

        return finalResult;
    }

    // UC 10: Count by city across books
    public int GetCountByCityAcrossBooks(string city)
    {
        int total = 0;
        for (int i = 0; i < count; i++)
            total += addressBooks[i].GetCountByCity(city);
        return total;
    }

    // UC 10: Count by state across books
    public int GetCountByStateAcrossBooks(string state)
    {
        int total = 0;
        for (int i = 0; i < count; i++)
            total += addressBooks[i].GetCountByState(state);
        return total;
    }
}
