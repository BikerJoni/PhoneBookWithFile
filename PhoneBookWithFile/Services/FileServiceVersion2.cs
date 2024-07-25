using System;
using PhoneBookWithFile.Model;
using System.IO;

namespace PhoneBookWithFile.Services
{
    internal class FileServiceVersion2 : IFileServiceVersion2
    {
        private const string filePath = "../../../phoneBook2.json";
        public void AddContact(Contact contact)

        {
            string newContact = $"{contact.Name}, {contact.Number}";
            File.AppendAllText(filePath, newContact + "\n");
        }

        public void SearchContact(string name)
        {
            string[] allContacts = File.ReadAllLines(filePath);
            foreach (string oneContact in allContacts)
            {
                string splitName = oneContact.Split(',')[0];
                if (splitName == name) 
                {
                    Console.WriteLine(oneContact);
                }

            }
        }

        public void RemoveContact(string name)
        {
            string contacts = ""; 
            string[] allContacts = File.ReadAllLines(filePath);
            foreach (string oneContact in allContacts)
            {
                string splitName = oneContact.Split(',')[0];
                if (!splitName.ToUpper().Equals(name.ToUpper()))
                {
                    contacts += oneContact + "\n";
                }

            }
            File.Delete(filePath);
            EnsureFileExist();
            File.AppendAllText(filePath, contacts);

        }

        private static void EnsureFileExist()
        {
            bool isFilePresent = !File.Exists(filePath);
            if (isFilePresent) 
            {
                File.Create(filePath).Close();
            }
        }

        
    }   
}
