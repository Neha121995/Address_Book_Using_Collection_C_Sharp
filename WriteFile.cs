using Address_Book_Using_Collection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Address_Book_Problem
{
    class WriteFile
    {
        public static string path = @"C:\Users\jagta\source\Address_Book_Using_Collection\file.txt";
        public static void WriteUsingStreamWriter(List<Contacts> data)
        {

            if (File.Exists(path))
            {
                File.WriteAllText(path, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("FirstName\tLastName\t Address\t City\t State\t ZipCode\t PhoneNumber\t Email");
                    foreach (Contacts contact in data)
                    {
                        streamWriter.WriteLine(contact.firstName + "\t" + contact.lastName + "\t" + contact.address + "\t" + contact.city + "\t" + contact.state + "\t" + contact.zipCode + "\t" + contact.phoneNumber + "\t" + contact.eMail);
                    }
                    streamWriter.Close();
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void readFile()
        {
            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
    }
}
