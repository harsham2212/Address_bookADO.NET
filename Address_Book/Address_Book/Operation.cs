using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Operation
    {
        private SqlConnection con;
        //To Handle connection related activities    
        private void Connection()
        {
            string constr = @"Data Source=FRIDAY\BARCA;Database=AddressBookServiceDB;Trusted_Connection=true";
            con = new SqlConnection(constr);

        }
        //To Add details    
        public AddressBookModel AddData(AddressBookModel data)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("sp_AddAddressBook", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@firstname", data.firstname);
                com.Parameters.AddWithValue("@lastname", data.lastname);
                com.Parameters.AddWithValue("@address", data.address);
                com.Parameters.AddWithValue("@city", data.city);
                com.Parameters.AddWithValue("@state", data.state);
                com.Parameters.AddWithValue("@zip", data.zip);
                com.Parameters.AddWithValue("@phonenumber", data.phonenumber);
                com.Parameters.AddWithValue("@email", data.email);
                com.Parameters.AddWithValue("@name", data.name);
                com.Parameters.AddWithValue("@type", data.type);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                return data;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //To Delete Person details    
        public int DeletePersonDetails(int id)
        {
            try
            {
                Connection();
                SqlCommand com = new SqlCommand("DeleteAddressBook", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i >= 1)
                {

                    return id;

                }
                else
                {

                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
