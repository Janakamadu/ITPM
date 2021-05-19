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
    public partial class Edit_Session : Form
    {
        public Edit_Session()
        {
            InitializeComponent();
        }
      

        private void SesDELETE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM add_session WHERE Session_ID ='" + SescomboBoxRollNo.Text + "'";
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

        private void SescomboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query = "SELECT * from add_session where Session_ID='" + SescomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader;

            try
            {
                conn.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    String LName = dReader.GetString("LName");
                    String LName2 = dReader.GetString("LName2");
                    String SubjectName = dReader.GetString("SubjectName");
                    String SubjectCode = dReader.GetString("SubjectCode");
                    String GroupID = dReader.GetString("GroupID");
                    String tag = dReader.GetString("tag");
                    String NoOfStudent = dReader.GetString("NoOfStudent");
                    String Duration = dReader.GetString("Duration");
                    String GenerateSession = dReader.GetString("GenerateSession");

                    SesEcomboBox1.Text = LName;
                    SesEtextBox1.Text = LName2;
                    SesEcomboBox2.Text = SubjectName;
                    SesEcomboBox3.Text = SubjectCode;
                    SesEcomboBox4.Text = GroupID;
                    SesEcomboBox5.Text = tag;
                    SesEtextBox2.Text = NoOfStudent;
                    SesEtextBox3.Text = Duration;
                    SesEtextBox4.Text = GenerateSession;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void SesUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE add_session SET LName='" + SesEcomboBox1.Text + "',LName2='" + SesEtextBox1.Text + "',SubjectName='" + SesEcomboBox2.Text + "',SubjectCode='" + SesEcomboBox3.Text + "',GroupID='" + SesEcomboBox4.Text + "',tag='" + SesEcomboBox5.Text + "',NoOfStudent='" + SesEtextBox2.Text + "',Duration='" + SesEtextBox3 + "',GenerateSession='" + SesEtextBox4 + "'where Session_ID ='" + SescomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Session record Update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the Session record" + ex);

            }
        }
    }
}
