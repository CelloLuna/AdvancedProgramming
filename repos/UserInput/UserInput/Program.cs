using System;
using MySql.Data.MySqlClient;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            processInput();

            void processInput()
            {
                int userInput = DisplayMenu();
                Console.WriteLine("Here" + userInput);
                
                if (userInput == 1)
                {
                    Create();
                }
                if (userInput == 2)
                {
                    Read();
                }
                if (userInput == 3)
                {
                   Update();
                }
                if (userInput == 4)
                {
                    Delete();
                }
                if (userInput == 5)
                {
                    Console.WriteLine("Goodbye");
                    System.Environment.Exit(0);
                } else
                {
                    Console.WriteLine("Invalid Option");
                    DisplayMenu();
                }
            }

            int DisplayMenu()
            {
                Console.WriteLine("");
                Console.WriteLine();
                Console.WriteLine("1.Create");
                Console.WriteLine("2.Read");
                Console.WriteLine("3.Update");
                Console.WriteLine("4.Delete");
                Console.WriteLine("5.EXIT");

                var input = Console.ReadLine();
                return Convert.ToInt32(input);
            }

            void Create()
            {
                try
                 {
                     string connectionString;
                     connectionString = "server=localhost;port=3306;uid=root;pwd='';database=cellodb;charset=utf8;SslMode=none;";
                     MySqlConnection con = new MySqlConnection(connectionString);
                     con.Open();

                     Console.WriteLine("Database connection is" + con.State.ToString() + "." + Environment.NewLine);

                     MySqlCommand com = con.CreateCommand();

                     com.CommandText = "INSERT INTO students(firstName, lastName, email) VALUES ('test', 'test1', 'test@gmail.com')";

                     com.ExecuteNonQuery();
                     Console.WriteLine("Data inserted successfully");
                     con.Close();

                 }
                 catch (MySql.Data.MySqlClient.MySqlException ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                 }
                //Console.WriteLine("Create");
                Console.ReadKey();
                processInput();
            }

            void Read()
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

                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {

                            str += Convert.ToString(rd.GetInt32(0)) + "\t" + rd.GetString(1) + "\t\t" + rd.GetString(2) + "\t" + rd.GetString(3) + Environment.NewLine;

                        }

                        Console.WriteLine(str);
                        rd.Close();
                        con.Close();

                        Console.WriteLine("Database connection is " + con.State.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No Data Available");
                        rd.Close();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message.ToString());
                }
                //Console.WriteLine("Read");
                Console.ReadKey();
                processInput();
            }

            void Update()
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
                //Console.WriteLine("Update");
                Console.ReadKey();
                processInput();
            }
            void Delete()
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
                 }
                 catch (MySql.Data.MySqlClient.MySqlException ex)
                 {
                     Console.WriteLine("Error: " + ex.Message);
                 }
                //Console.WriteLine("Delete");
                Console.ReadKey();
                processInput();
            }
        }
    }
}
