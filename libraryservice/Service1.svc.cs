using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace libraryservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string AddRecord(Book bk)
        {
            string result = "";
            try
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GDTJ4E;Initial Catalog=library;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO libinfo (Id,student_name,student_id,book_name,author_name,price)  
                                               Values(@Id,@student_name,@student_id,@book_name,@author_name,@price)";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Id", bk.Id);
                cmd.Parameters.AddWithValue("@student_name", bk.student_name);
                cmd.Parameters.AddWithValue("@student_id", bk.student_id);
                cmd.Parameters.AddWithValue("@book_name", bk.book_name);
                cmd.Parameters.AddWithValue("@author_name", bk.author_name);
                cmd.Parameters.AddWithValue("@price", bk.price);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result;
        }

        //Retrieve Data  
        //Retrive Record  
        public DataSet GetRecords()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GDTJ4E;Initial Catalog=library;Integrated Security=True;");
                string Query = "SELECT * FROM libinfo";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }

        //Delete Record  
        public string DeleteRecords(Book bk)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GDTJ4E;Initial Catalog=library;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM libinfo Where Id=@Id";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Id", bk.Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }

        //Search bkloyee Record  
        public DataSet SearchRecord(Book bk)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GDTJ4E;Initial Catalog=library;Integrated Security=True;");
                string Query = "SELECT * FROM libinfo WHERE Id=@Id";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Id", bk.Id);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }

        //UPDATE RECORDS  

        public string Updateinfo(Book bk)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-6GDTJ4E;Initial Catalog=library;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE libinfo SET student_name=@student_name,student_id=@student_id WHERE Id=@Id";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@Id", bk.Id);
            cmd.Parameters.AddWithValue("@student_name", bk.student_name);
            cmd.Parameters.AddWithValue("@student_id", bk.student_id);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }
    }
}
