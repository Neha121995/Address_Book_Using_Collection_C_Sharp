﻿using System;

namespace Address_Book_Using_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using Collection");
            AddressBookCollection.AddContact();
            Console.WriteLine("\n");
            AddressBookCollection.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBookCollection.EditContact();
            Console.WriteLine("\n");
            AddressBookCollection.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBookCollection.DeleteContact();
            AddressBookCollection.ContactsDisplay();
        }
    }
}
