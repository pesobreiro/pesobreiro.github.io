// Main.cs created with MonoDevelop
// User: pedrosobreiro at 19:07 06/12/2008
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//
using System;
using System.Data;
using Mono.Data.SqliteClient;

public class Teste
{ 
    public static void Main(string[] args)
    {
       string connectionString = "URI=file:SqliteTest.db";
       IDbConnection dbcon;
       dbcon = (IDbConnection) new SqliteConnection(connectionString);
       dbcon.Open();
       IDbCommand dbcmd = dbcon.CreateCommand();
       // requires a table to be created named employee
       // with columns firstname and lastname
       // such as,
       //        CREATE TABLE employee (
       //           firstname varchar(32),
       //           lastname varchar(32));
       string sql =
          "SELECT firstname, lastname " +
          "FROM employee";
       dbcmd.CommandText = sql;
       IDataReader reader = dbcmd.ExecuteReader();
       while(reader.Read()) {
            string FirstName = reader.GetString (0);
            string LastName = reader.GetString (1);
            Console.WriteLine("Name: " +
                FirstName + " " + LastName);
       }
       // clean up
       reader.Close();
       reader = null;
       dbcmd.Dispose();
       dbcmd = null;
       dbcon.Close();
       dbcon = null;
    }
}
