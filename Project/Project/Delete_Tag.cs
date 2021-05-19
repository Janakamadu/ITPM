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
    public partial class Delete_Tag : Form
    {
        public Delete_Tag()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM tag";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    String idtag = dataReader.GetString("idtag");
                    comboBoxTagID.Items.Add(idtag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void TagbuttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM tag WHERE idtag ='" + comboBoxTagID.Text + "'";
            MySqlConnection conns = new MySqlConnection(connectionString);
            MySqlCommand Cmd = new MySqlCommand(delQuery, conns);
            MySqlDataReader mReader;

            try
            {
                conns.Open();
                mReader = Cmd.ExecuteReader();
                MessageBox.Show("Tag record delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete the Tag record" + ex);

            }
        }
    }
}
