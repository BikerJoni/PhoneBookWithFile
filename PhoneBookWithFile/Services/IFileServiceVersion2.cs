using PhoneBookWithFile.Model;

namespace PhoneBookWithFile.Services
{
    internal interface IFileServiceVersion2
    {
        void AddContact(Contact contact);

        void SearchContact(string name);

        void RemoveContact(string name);
    }
}
