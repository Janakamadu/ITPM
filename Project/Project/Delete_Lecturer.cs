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
    public partial class Delete_lecturer : Form
    {
        public Delete_lecturer()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM add_lecturer";
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
                    comboBoxLecturerID.Items.Add(ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM add_lecturer WHERE ID ='" + comboBoxLecturerID.Text + "'";
            MySqlConnection conns = new MySqlConnection(connectionString);
            MySqlCommand Cmd = new MySqlCommand(delQuery, conns);
            MySqlDataReader mReader;

            try
            {
                conns.Open();
                mReader = Cmd.ExecuteReader();
                MessageBox.Show("Lecture record delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete the lecturer record" + ex);

            }
        }

        private void LLabel1_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }

        private void LLabel2_Click(object sender, EventArgs e)
        {

            Edit_Lecturer Edit_Lecturer = new Edit_Lecturer();
            Edit_Lecturer.Show();
        }

        private void LLabel3_Click(object sender, EventArgs e)
        {
            View_Lecturer view_Lecturer = new View_Lecturer();
            view_Lecturer.Show();

        }

        private void comboBoxLecturerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteLecturerlabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
