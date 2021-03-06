using Address_Book_Using_Collection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Address_Book_Problem
{
    class WriteFile
    {
        public static string path = @"C:\Users\jagta\source\Address_Book_Using_Collection\file.txt";
        public static string pathCsv = @"C:\Users\jagta\source\Address_Book_Using_Collection\ABdata.csv";
        public static string pathJson = @"C:\Users\jagta\source\Address_Book_Using_Collection\ABdata.json";
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

        public static void csvFileWriter(List<Contacts> data)
        {

            if (File.Exists(pathCsv))
            {
                File.WriteAllText(pathCsv, String.Empty);
                using (StreamWriter streamWriter = File.AppendText(pathCsv))
                {
                    streamWriter.WriteLine("FirstName,LastName,Address,City,State,Zip,Contact,Email");
                    foreach (Contacts contacts in data)
                    {
                        streamWriter.WriteLine(contacts.firstName + "," + contacts.lastName + "," + contacts.address + "," + contacts.city + "," + contacts.state + "," + contacts.zipCode + "," + contacts.phoneNumber + "," + contacts.eMail);
                    }
                    streamWriter.Close();
                    Console.WriteLine("Contacts Stored in Csv_File.");
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }
        public static void readFromCSVFile()
        {
            if (File.Exists(pathCsv))
            {
                using (StreamReader streamReader = File.OpenText(pathCsv))
                {
                    string data = "";
                    while ((data = streamReader.ReadLine()) != null)
                    {
                        string[] csv = data.Split(",");
                        foreach (string dataCsv in csv)
                        {
                            Console.Write(dataCsv + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("File not avilable..");
            }
        }

        public static void WriteContactsInJSONFile(List<Contacts> contacts)
        {
            if (File.Exists(pathJson))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                using (StreamWriter streamWriter = new StreamWriter(pathJson))
                using (JsonWriter writer = new JsonTextWriter(streamWriter))
                {
                    jsonSerializer.Serialize(writer, contacts);
                }
                Console.WriteLine("Contact stored in Json File...");
            }
            else
            {
                Console.WriteLine("File not found...");
            }
        }
        public static void ReadContactsFromJSONFile()
        {
            if (File.Exists(pathJson))
            {
                IList<Contacts> contactsRead = JsonConvert.DeserializeObject<IList<Contacts>>(File.ReadAllText(pathJson));
                foreach (Contacts contact in contactsRead)
                {
                    contact.print();
                }
            }
            else
            {
                Console.WriteLine("File not found...");
            }
        }
    }
}
