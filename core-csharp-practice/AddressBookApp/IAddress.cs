interface IAddressBook
{
    // Add contact
    void AddContact(Contact contact);

    // Edit / Delete contact
    void EditContact(string keyword);
    void DeleteContact(string keyword);

    // Display all contacts
    void DisplayAll();

    // Duplicate check
    bool IsDuplicate(Contact contact);

    // Search by city / state
    Contact[] GetPersonsByCity(string city);
    Contact[] GetPersonsByState(string state);

    // Count by city / state
    int GetCountByCity(string city);
    int GetCountByState(string state);

    // Sorting
    void SortByName();
    void SortByCity();
    void SortByState();
    void SortByZip();
}
