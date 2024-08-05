namespace PhoneBookWithFile.Services
{
    internal interface IFileServiceVersion2
    {
        void AddContact();
        void SearchContact();
        void RemoveContact();
        void ReadAllContacts();
        void UpdateContact();
        void ClearAllContacts();
    }
}