using AddressBook_Ado;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("! Address_Book !");

        AddressBookOperations operation = new AddressBookOperations();
        // operation.CreateDatabase();
        operation.CreateTable();  

       



    }
}