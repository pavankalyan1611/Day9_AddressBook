using Address_Book;



AddressBook address = new AddressBook();
string command = "";

while (command != "exit")
{
    Console.WriteLine("Please enter a command: add , edit ,display, exit: ");
    command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "add":
            address.AddPerson();
            break;
        case "edit":
            address.EditContact();
            break;
        case "display":
            address.Display();
            break;
        case "exit":
            break;
    }
}
