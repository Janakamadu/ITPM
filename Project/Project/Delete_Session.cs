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
    public partial class Delete_Session : Form
    {
        public Delete_Session()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM add_session";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    String Session_ID = dataReader.GetString("Session_ID");
                    SescomboBoxLecturerID.Items.Add(Session_ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void SesbuttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM add_session WHERE Session_ID ='" + SescomboBoxLecturerID.Text + "'";
            MySqlConnection conns = new MySqlConnection(connectionString);
            MySqlCommand Cmd = new MySqlCommand(delQuery, conns);
            MySqlDataReader mReader;

            try
            {
                conns.Open();
                mReader = Cmd.ExecuteReader();
                MessageBox.Show("Session record delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete the Session record" + ex);

            }
        }
    }
}
