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
    public partial class NotARoom : Form
    {
        public NotARoom()
        {
            InitializeComponent();
        }

        private void NotARoomADD_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO roomnot(Room,Day,StartTime,EndTime) values('" + this.NotARoomtextBox1.Text + "','" + this.NotARoomcomboBox1.Text + "','" + this.NotARoomtextBox2.Text + "','" + this.NotARoomtextBox3.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Lecturer details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }

        }

        private void NATRView_Click(object sender, EventArgs e)
        {
           NotATRView notATRView = new NotATRView();
           notATRView.Show();
        }
    }
}
