interface IFileService
{
    // Write Address Book to file
    void Write(AdBook addressBook);

    // Read Address Book from file
    AdBook Read();
}
