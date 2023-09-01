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
            FirstName = "Yoman",
            LastName = "hehe",
            Address = "abc",
            City = "bcd",
            State = "abcd",
            Zip = 123456,
            PhoneNumber = "1234567890",
            Email = "bcd@gmail.com",

        };
        //operation.Result(operation.AddEmployee(dataset));


        AddressModel edit = new AddressModel()
        {
            FirstName = "hey ",
            LastName = "Yooo",
            Address = "a",
            City = "a",
            State = "bbbbb",
            Zip = 111111,
            PhoneNumber = "1111111111",
            Email = "b@gmail.com",

        };
        //operation.Result(operation.InsertData(edit));
        operation.Result(operation.EditData(edit));



    }
}