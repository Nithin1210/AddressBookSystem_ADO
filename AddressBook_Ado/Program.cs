using AddressBook_Ado;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("! Address_Book !");

        AddressBookOperations operation = new AddressBookOperations();
        // operation.CreateDatabase();
        //operation.CreateTable();

        AddressModel dataset = new AddressModel()
        {
            FirstName = "Yo",
            LastName = "Man",
            Address = "abc",
            City = "bcd",
            State = "abcd",
            Zip = 601201,
            PhoneNumber = "1234567890",
            Email = "abc@gmail.com",

        };
        operation.Result(operation.AddEmployee(dataset));



    }
}