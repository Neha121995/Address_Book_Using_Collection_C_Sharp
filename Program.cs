﻿using System;

namespace Address_Book_Using_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using Collection");
            AddressBookCollection.AddContact();
            AddressBookCollection.ContactsDisplay();
            AddressBookCollection.EditContact();
            AddressBookCollection.ContactsDisplay();
        }
    }
}
