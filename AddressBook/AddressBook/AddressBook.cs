using System;
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
        public void Display()
        {
            foreach (Contact contact in addressBook)
            {
                Console.WriteLine(contact.FirstName);
                Console.WriteLine(contact.LastName);
                Console.WriteLine(contact.Address);
                Console.WriteLine(contact.State);
                Console.WriteLine(contact.PhNo);
                Console.WriteLine(contact.Zip);
            }
        }
    }
}
