using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            MySqlConnection con = new MySqlConnection(ConnectString);
            MySqlDataAdapter madapter = new MySqlDataAdapter();
            madapter.SelectCommand = new MySqlCommand("Select * from new_table",con);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(madapter);

            con.Open();
            DataSet ds = new DataSet();
            MessageBox.Show("Connection with MySql database Established");

        }
    }
}
