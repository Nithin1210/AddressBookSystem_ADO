using AddressBook_Ado;
using System.Data;

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
        //operation.Result(operation.InsertData(dataset));
        //operation.Result(operation.EditData(edit));

        //AddressModel delete = new AddressModel()
        //{
        //    FirstName = "Yoman",
        //};
        //operation.Result(operation.DeleteData(dataset));

        string citysearch = "bcd";
        string statesearch = "abcd";
        //operation.GetAllEmployeeDetailsByCity(citysearch);
        //operation.DisplayAllDataByCity(citysearch);
        //operation.GetAllEmployeeDetailsByState(statesearch);
        //operation.DisplayAllDataByState(statesearch);

        //operation.SizeByCity();
        //operation.SizeByState();

        //operation.GetPeopleInCitySortedByName(citysearch);

        // UC-9 Done in DataBase In mssql ...

        //operation.CountByType();

        //operation.PersonAsTwoRelation("SadMan", "Others");


        List<AddressModel> list = new List<AddressModel>();
        list.Add(new AddressModel()
        {
            FirstName = "a",
            LastName = "a",
            Address = "a",
            City = "a",
            State = "a",
            Zip = 12345,
            PhoneNumber = "1234567890",
            Email = "a@gmail.com",
            Relation = "Others"
        });
        list.Add(new AddressModel()
        {
            FirstName = "b",
            LastName = "b",
            Address = "b",
            City = "b",
            State = "b",
            Zip = 12342,
            PhoneNumber = "1234567890",
            Email = "b@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "c",
            LastName = "c",
            Address = "c",
            City = "c",
            State = "c",
            Zip = 12343,
            PhoneNumber = "1234567890",
            Email = "c@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "d",
            LastName = "d",
            Address = "d",
            City = "d",
            State = "d",
            Zip = 12344,
            PhoneNumber = "1234567890",
            Email = "d@gmail.com",
            Relation = "Others"
        }); list.Add(new AddressModel()
        {
            FirstName = "e",
            LastName = "e",
            Address = "e",
            City = "e",
            State = "e",
            Zip = 12345,
            PhoneNumber = "1234567890",
            Email = "e@gmail.com",
            Relation = "Others"
        });

        WithAndWithOutThread thread = new WithAndWithOutThread();
        thread.UsingWithThread(list);
        thread.UsingWithThread(list);




    }
}