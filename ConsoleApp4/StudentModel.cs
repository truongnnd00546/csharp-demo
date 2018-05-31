using System;
using MySql.Data.MySqlClient;

namespace ConsoleApp4
{
    public class StudentModel
    {
        private const string SeverName = "localhost";
        private const string DatabaseName = "student-manager";
        private const string Username = "root";
        private const string Password = "";

        public void Save(Student student)
        {
            var cnnString = $"Server={SeverName};Database={DatabaseName};Uid={Username};Pwd={Password};SslMode=none";
            MySqlConnection connection = new MySqlConnection(cnnString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(
                    "insert into students(rollnumber,name,email,phone)values(@val1,@val2,@val3,@val4)",connection
                );
            cmd.Parameters.AddWithValue("@val1","D00546");
            cmd.Parameters.AddWithValue("@val2","Bale");
            cmd.Parameters.AddWithValue("@val3","bale@gmail.com");
            cmd.Parameters.AddWithValue("@val4","227662");

            cmd.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Okie");

        }
    }
}