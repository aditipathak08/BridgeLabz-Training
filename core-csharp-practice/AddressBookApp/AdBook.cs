using System;

class AdBook : IAddressBook
{
    private Contact[] contacts;
    private int count;

    // Constructor
    public AdBook()
    {
        contacts = new Contact[2];
        count = 0;
    }

    // UC 5: Add contact
    public void AddContact(Contact newContact)
    {
        if (IsDuplicate(newContact))
        {
            Console.WriteLine("Duplicate contact not allowed.");
            return;
        }

        if (count == contacts.Length)
        {
            Contact[] temp = new Contact[contacts.Length + 1];
            for (int i = 0; i < contacts.Length; i++)
            {
                temp[i] = contacts[i];
            }
            contacts = temp;
        }

        contacts[count++] = newContact;
        Console.WriteLine("Contact added successfully!");
    }

    // UC 7: Duplicate check
    public bool IsDuplicate(Contact contact)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Equals(contact))
                return true;
        }
        return false;
    }

    // UC 6: Edit contact
    public void EditContact(string keyword)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Search(keyword))
            {
                contacts[i].Edit();
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // UC 6: Delete contact
    public void DeleteContact(string keyword)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].Search(keyword))
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }

                contacts[count - 1] = null;
                count--;
                Console.WriteLine("Contact deleted successfully!");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // Display all contacts
    public void DisplayAll()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            contacts[i].Display();
            Console.WriteLine("------------------");
        }
    }

    // UC 8: Search by city
    public Contact[] GetPersonsByCity(string city)
    {
        Contact[] result = new Contact[count];
        int index = 0;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                result[index++] = contacts[i];
            }
        }

        Contact[] finalResult = new Contact[index];
        for (int i = 0; i < index; i++)
            finalResult[i] = result[i];

        return finalResult;
    }

    // UC 8: Search by state
    public Contact[] GetPersonsByState(string state)
    {
        Contact[] result = new Contact[count];
        int index = 0;

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                result[index++] = contacts[i];
            }
        }

        Contact[] finalResult = new Contact[index];
        for (int i = 0; i < index; i++)
            finalResult[i] = result[i];

        return finalResult;
    }

    // UC 10: Count by city
    public int GetCountByCity(string city)
    {
        int cityCount = 0;
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                cityCount++;
        }
        return cityCount;
    }

    // UC 10: Count by state
    public int GetCountByState(string state)
    {
        int stateCount = 0;
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                stateCount++;
        }
        return stateCount;
    }

    // UC 11: Sort by name
    public void SortByName()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(contacts[i].GetFirstName(),
                                   contacts[j].GetFirstName(), true) > 0)
                {
                    Contact temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
    }

    // UC 12: Sort by city
    public void SortByCity()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(contacts[i].GetCity(),
                                   contacts[j].GetCity(), true) > 0)
                {
                    Contact temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
    }

    // UC 12: Sort by state
    public void SortByState()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(contacts[i].GetState(),
                                   contacts[j].GetState(), true) > 0)
                {
                    Contact temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
    }

    // UC 12: Sort by zip
    public void SortByZip()
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (string.Compare(contacts[i].GetZip(),
                                   contacts[j].GetZip(), true) > 0)
                {
                    Contact temp = contacts[i];
                    contacts[i] = contacts[j];
                    contacts[j] = temp;
                }
            }
        }
    }
}
