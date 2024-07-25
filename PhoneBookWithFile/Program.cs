using PhoneBookWithFile.Model;
using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileServiceVersion2 fileServiceVersion2 = new FileServiceVersion2();
            Contact contact = new Contact();
            
            Console.Write("Enter the Name : ");
            contact.Name = Console.ReadLine();
            Console.Write("Enter the Number: ");
            contact.Number = Console.ReadLine();

            //fileServiceVersion2.AddContact(contact);

            //fileServiceVersion2.SearchContact(contact.Name);
            fileServiceVersion2.RemoveContact(contact.Name);

        }
    }
}