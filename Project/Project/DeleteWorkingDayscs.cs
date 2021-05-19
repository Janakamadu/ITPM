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
    public partial class DeleteWorkingDayscs : Form
    {
        public DeleteWorkingDayscs()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM addworkintable";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    String ID = dataReader.GetString("ID");
                    comboBoxworkingID.Items.Add(ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void WDDbuttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM addworkintable WHERE ID ='" + comboBoxworkingID.Text + "'";
            MySqlConnection conns = new MySqlConnection(connectionString);
            MySqlCommand Cmd = new MySqlCommand(delQuery, conns);
            MySqlDataReader mReader;

            try
            {
                conns.Open();
                mReader = Cmd.ExecuteReader();
                MessageBox.Show("Working Days & Hours record delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete the Working Days & Hours record" + ex);

            }
        }
    }
}
