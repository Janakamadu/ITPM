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
    public partial class Delete_Location : Form
    {
        public Delete_Location()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM location";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    String locationID = dataReader.GetString("locationID");
                    comboBoxLocationID.Items.Add(locationID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void buttonLocDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM location WHERE locationID ='" + comboBoxLocationID.Text + "'";
            MySqlConnection conns = new MySqlConnection(connectionString);
            MySqlCommand Cmd = new MySqlCommand(delQuery, conns);
            MySqlDataReader mReader;

            try
            {
                conns.Open();
                mReader = Cmd.ExecuteReader();
                MessageBox.Show("Location record delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete the Location record" + ex);

            }
        }
    }
}
