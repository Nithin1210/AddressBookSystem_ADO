using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AddressBook_Ado
{
    public class AddressBookOperations
    {
        private SqlConnection con;
        private void connection()
        {
            string connectionStr = "data source = (localdb)\\MSSQLLocalDB; initial catalog=AddressBookService;integrated security = true ";
            con = new SqlConnection(connectionStr);
        }

        public void CreateDatabase()
        {
            SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master;integrated security = true ");
            try
            {
                string query = "Create Database AddressBookService";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                con.Close();
            }
        }

        public void CreateTable()
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                string query = "Create table AddressBook(\r\nid int primary key identity(1,1),\r\nfirstName varchar(20),\r\nlastName varchar(20),\r\naddress varchar(30), \r\ncity varchar(20),\r\nstate varchar(20), \r\nzip bigint, \r\nphone varchar(10),\r\nemail varchar(30),\r\n)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("** Table Created Suucessfully **");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" NO DATA !!");
            }
            finally
            {
                con.Close();
            }
        }
       

        public bool AddEmployee(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                com.Parameters.AddWithValue("@LastName", obj.LastName);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@State", obj.State);
                com.Parameters.AddWithValue("@Zip", obj.Zip);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Email", obj.Email);
                con.Open();
                int i = com.ExecuteNonQuery(); 
                con.Close();
                Console.WriteLine(" Done !!");
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                Console.WriteLine("Error !! , Retry Data in SQL");
            }
            finally
            {
                con.Close();
            }

        }
        public void Result(bool data)
        {
            if (data)
            {
                Console.WriteLine("Code ok, You can Continue !!");
                return;
            }
            Console.WriteLine("!!Oops ,Something went wrong");
        }

        public bool InsertData(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                com.Parameters.AddWithValue("@LastName", obj.LastName);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@State", obj.State);
                com.Parameters.AddWithValue("@Zip", obj.Zip);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Email", obj.Email);
                con.Open();
                int i = com.ExecuteNonQuery(); 
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public bool EditData(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("EditContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                com.Parameters.AddWithValue("@LastName", obj.LastName);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@State", obj.State);
                com.Parameters.AddWithValue("@Zip", obj.Zip);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Email", obj.Email);
                con.Open();
                int i = com.ExecuteNonQuery(); 
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }



    }

}
