interface IAddressBookSystem
{
    // UC 5 – Add multiple Address Books
    void AddAddressBook(string addressBookName);

    // Get Address Book by name
    AdBook GetAddressBook(string addressBookName);

    // UC 8 – Search across Address Books
    Contact[] SearchByCityAcrossBooks(string city);
    Contact[] SearchByStateAcrossBooks(string state);

    // UC 10 – Count across Address Books
    int GetCountByCityAcrossBooks(string city);
    int GetCountByStateAcrossBooks(string state);
}
