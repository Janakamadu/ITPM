using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Project
{
    class DataAdpter
    {
        string connectionString = "";
        MySqlConnection mysqlConnection;
        MySqlCommand mysqlCommand;
        private string mysql;

        public DataAdpter()
        {
            connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            mysqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlDataReader excecuteSQL(String sql)
        {

            mysqlCommand = new MySqlCommand(mysql, mysqlConnection);
            mysqlConnection.Open();
            mysqlCommand.CommandText = sql;
            return mysqlCommand.ExecuteReader();
        }
    }
}
