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
    public partial class Edit_Lecturer : Form
    {

        public Edit_Lecturer()
        {
            InitializeComponent();

        }
        private void comboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query ="SELECT * from add_lecturer where id='"+comboBoxRollNo.Text+"'";
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
                    String LEmployeeID = dReader.GetString("LEmployeeID");
                    String Faculty = dReader.GetString("Faculty");
                    String Department = dReader.GetString("Department");
                    String Center = dReader.GetString("Center");
                    String Building = dReader.GetString("Building");
                    String Level = dReader.GetString("Level");
                    String Rank_no = dReader.GetString("Rank_no");
                    EdtextBox1.Text =  LName;
                    EdtextBox2.Text =  LEmployeeID;
                    EdcomboBox1.Text = Faculty;
                    EdcomboBox2.Text = Department;
                    EdcomboBox3.Text = Center;
                    EdcomboBox4.Text = Building;
                    EdcomboBox5.Text = Level;
                    EdtextBox3.Text =  Rank_no;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }    
        private void LUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE add_lecturer SET LName='" + EdtextBox1.Text + "',LEmployeeID='" + EdtextBox2.Text + "',Faculty='" + EdcomboBox1.Text + "',Department='" + EdcomboBox2.Text + "',Center='" + EdcomboBox3.Text+"',Building='"+EdcomboBox4.Text+"',Level='"+EdcomboBox5.Text+"',Rank_no='"+EdtextBox3+"'where ID ='"+comboBoxRollNo.Text+"'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Lecture record Update successfully");

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Unable to update the lecturer record" + ex);

            }
        }

        private void LLabel3_Click(object sender, EventArgs e)
        {
            View_Lecturer view_Lecturer = new View_Lecturer();
            view_Lecturer.Show();
        }

        private void LEDELETE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string delQuery = "DELETE FROM add_lecturer WHERE ID ='" + comboBoxRollNo.Text + "'";
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
            Edit_Lecturer edit_Lecturer = new Edit_Lecturer();
            edit_Lecturer.Show();
        }
    }
    
}

