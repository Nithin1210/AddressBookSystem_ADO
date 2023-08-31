using AddressBook_Ado;
using Azure;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("! Address_Book !");

        AddressBookOperations operation = new AddressBookOperations();
        operation.CreateDatabase();

    }
}