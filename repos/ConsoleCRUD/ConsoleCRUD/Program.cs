using System;
using MySql.Data.MySqlClient;

namespace ConsoleCRUD
{
    class Program
    {
        static void Main(string[] args)
        {

            //Read();
            //Create();
            //Delete();
            Edit();
        }

        static void Read()
        {
            try
            {
                string connectionString;
                connectionString = "server=localhost;port=3306;uid=root;pwd='';database=cellodb;charset=utf8;SslMode=none;";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                Console.WriteLine("Connection Good. It is " + con.State.ToString() + Environment.NewLine);
                MySqlCommand com = con.CreateCommand();

                com.CommandType = System.Data.CommandType.Text;
                //com.CommandText = "SELECT * FROM students"; //Select all record
                //com.CommandText = "SELECT * FROM students WHERE id = 23";// only select user 23
                //com.CommandText = "SELECT * FROM students WHERE firstName LIKE 'name%'"; //Where name starts with "Name"
                com.CommandText = "SELECT * FROM students WHERE id NOT IN(23,25)"; //excludes id of 23,24, and 25

                MySqlDataReader rd = com.ExecuteReader();
                string str = "[id]\t[firstName]\t[lastName]\t[email]" + Environment.NewLine;

                if(rd.HasRows)
                {
                    while (rd.Read()) {

                        str += Convert.ToString(rd.GetInt32(0)) + "\t" + rd.GetString(1) + "\t\t" + rd.GetString(2) + "\t" + rd.GetString(3) + Environment.NewLine;
                       
                    }

                    Console.WriteLine(str);
                    rd.Close();
                    con.Close();

                    Console.WriteLine("Database connection is " + con.State.ToString());
                } else
                {
                    Console.WriteLine("No Data Available");
                    rd.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
        }

        static void Create()
        {
            try
            {
                string connectionString;
                connectionString = "server=localhost;port=3306;uid=root;pwd='';database=cellodb;charset=utf8;SslMode=none;";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                Console.WriteLine("Database connection is" + con.State.ToString() + "." +Environment.NewLine);

                MySqlCommand com = con.CreateCommand();

                com.CommandText = "INSERT INTO students(firstName, lastName, email) VALUES ('test', 'test1', 'test@gmail.com')";

                com.ExecuteNonQuery();
                Console.WriteLine("Data inserted successfully");
                con.Close();

            } catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void Delete()
        {
            
            try
            {
                string connectionString;
                connectionString = "server=localhost;port=3306;uid=root;pwd='';database=cellodb;charset=utf8;SslMode=none;";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                Console.WriteLine("Database connection is" + con.State.ToString() + "." + Environment.NewLine);

                MySqlCommand com = con.CreateCommand();

                com.CommandText = "DELETE FROM students WHERE id = '28'";
                com.ExecuteNonQuery();
                Console.WriteLine("Data Deleted Successfully");
                con.Close();
            } catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        static void Edit()
        {
            try
            {
                string connectionString;
                connectionString = "server=localhost;port=3306;uid=root;pwd='';database=cellodb;charset=utf8;SslMode=none;";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();

                Console.WriteLine("Database connection is" + con.State.ToString() + "." + Environment.NewLine);

                MySqlCommand com = con.CreateCommand();

                com.CommandText = "UPDATE students SET firstName = 'change', lastName = 'change2', email = 'email@change.com' WHERE id = 26";
                com.ExecuteNonQuery();
                Console.WriteLine("Data updated successfully");
                con.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
        }
    }
}
