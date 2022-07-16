﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class AddressBook
    {
        public List<Contact> addressBook = new List<Contact>();
        public void AddNewContact()
        {
            Contact contact = new Contact();

            Console.WriteLine("enter first name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("enter second name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("enter address name");
            contact.Address = Console.ReadLine();

            Console.WriteLine("enter phno name");
            contact.PhNo = Console.ReadLine();

            Console.WriteLine("enter city name");
            contact.City = Console.ReadLine();

            Console.WriteLine("enter state name");
            contact.State = Console.ReadLine();

            Console.WriteLine("enter zip name");
            contact.Zip = Console.ReadLine();

            addressBook.Add(contact);
        }
        public void AddPerson()
        {
            Contact person = new Contact();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == person.FirstName.ToLower())
                {
                    Console.WriteLine("person already exist");
                    return;
                }
            }
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter city name: ");
            person.City = Console.ReadLine();
            Console.Write("Enter zip number: ");
            person.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.Email = Console.ReadLine();
            Console.Write("Enter Phone Email: ");
            person.PhNo = Console.ReadLine();
            Console.Write("Enter Address 1: ");
            person.Address = Console.ReadLine();
            addressBook.Add(person);
        }
        public void EditContact()
        {
            Console.WriteLine("enter the first name you want to edit");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    Console.WriteLine("enter which information you wnat to change");
                    Console.WriteLine("enter 1 to edit last name,2 to change the city,3 to zip,4 to Email,5 to phonenumber");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("enter the lastname");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the city");
                            contact.City = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the zip");
                            contact.Zip = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the phone number");
                            contact.PhNo = Console.ReadLine();
                            break;
                    }
                    return;
                }
            }
            Console.WriteLine("no contact with this firstname");

        }
        public void RemoveContact()
        {
            Console.WriteLine("enter the first name you want to remove");
            string firstname = Console.ReadLine();
            foreach (Contact contact in addressBook)
            {
                if (contact.FirstName.ToLower() == firstname.ToLower())
                {
                    addressBook.Remove(contact);
                    Console.WriteLine("the firstname you have entered is deleted ");
                    return;
                }
            }
            Console.WriteLine("contact not found");
        }
        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine($"Firstname \t{contact.FirstName}\n Lastname \t {contact.LastName}\n PhoneNumber \t{contact.PhNo}\ncity \t{contact.City}\n zip \t{contact.Zip}\n Email \t{contact.Email}\n Adress \t{contact.Address}\n ");
            }
        }
    }
}
