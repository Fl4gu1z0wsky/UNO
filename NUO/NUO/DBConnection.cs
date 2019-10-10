using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUO
{
    /// <summary>
    /// DBConnection is a class for the interaction between the database and the programm
    /// </summary>
    class DBConnection
    {
        //Declaration of the SQLiteConnection for further use in the code
        SQLiteConnection sqliteConn;

        /// <summary>
        /// Constructor of the DBConnection
        /// </summary>
        public DBConnection()
        {
            // Create a new database connection:
            sqliteConn = new SQLiteConnection("Data Source=NUO_SQLite.db; Version=3; Compress=True;");
            // Open the connection:
            sqliteConn.Open();

        }
        /// <summary>
        /// Insert the data inside a SQLiteCommand
        /// </summary>
        public void InsertData(string name, int score)
        {
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            cmd.CommandText = "INSERT INTO players (pseudo, score) VALUES('" + name + "', '" + score + "');";
            cmd.ExecuteNonQuery();

        }
        /// <summary>
        /// Create a List of string so the data can be read
        /// </summary>
        /// <returns>A List of string</returns>
        public List<string> ReadData()
        {
            SQLiteCommand cmd = sqliteConn.CreateCommand();
            cmd.CommandText = "SELECT col1, col2 FROM SampleTable";
            List<string> listCol1 = new List<string>();

            SQLiteDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string myReader = dataReader["col1"].ToString();
                listCol1.Add(myReader);
            }
            return listCol1;
        }
        /// <summary>
        /// Close the connection with the database
        /// </summary>
        public void Close()
        {
            sqliteConn.Close();
        }

        public List<int> GetIdCards()
        {
            

            List<int> listId = new List<int>();

            SQLiteCommand cmd = sqliteConn.CreateCommand();
            cmd.CommandText = "SELECT id FROM cards";


            SQLiteDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                listId.Add(Convert.ToSByte(dataReader["id"].ToString()));
            }

            return listId;

            
        }

    }
}
