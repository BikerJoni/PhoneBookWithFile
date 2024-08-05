using PhoneBookWithFile.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookWithFile.Services
{
    internal class TxtFileServise : FileServiceVersion2
    {
        private ILoggingService log;
        private string contact;
        private const string filePath = "../../../phoneBook.txt";

        
        public TxtFileServise()
        {
            this.log = new LoggingService();
            CreateFileIfNotExist();
    }
        public void AddContact()
        {
            File.AppendAllText(filePath, contact + Environment.NewLine);
        }

        public void ClearAllContacts()
        {
            Console.Clear();
            File.WriteAllText(filePath, "");
            Console.ForegroundColor = ConsoleColor.Red;
            log.LogInfoLine("All contacts are cleared successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ReadAllContacts()
        {
            throw new NotImplementedException();
        }

        public void RemoveContact()
        {
            throw new NotImplementedException();
        }

        public void SearchContact()
        {
            throw new NotImplementedException();
        }

        public void UpdateContact()
        {
            throw new NotImplementedException();
        }

        private static void CreateFileIfNotExist()
        {
            var isFileExists = File.Exists(filePath);
            if (isFileExists is false)
            {
                File.Create(filePath).Close();
            }
        }

    }
}
