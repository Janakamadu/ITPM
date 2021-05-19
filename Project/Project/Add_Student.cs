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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        private void StuADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO student(year_sem,programme,grp_no,sub_grp_no,grp_id,sub_grp_id) values('" + this.StutextBox1.Text + "','" + this.StucomboBox1.Text + "','" + this.StunumericUpDown1.Text + "','" + this.StunumericUpDown2.Text + "','" + this.StutextBox2.Text + "','" + this.StutextBox3.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Student details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }
        }

        private void StuCLEAR_Click(object sender, EventArgs e)
        {
            try
            {

                StutextBox1.Clear();
                StucomboBox1.Text = string.Empty;
                StunumericUpDown1.Value = 0;
                StunumericUpDown2.Value = 0;
                StutextBox2.Clear();
                StutextBox3.Clear();

                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void StuGenerate_Click(object sender, EventArgs e)
        {
            try
            {

                String year_sem = StutextBox1.Text;
                String programme = StucomboBox1.Text;

                int grp_no = Convert.ToInt32(StunumericUpDown1.Value);
                int sub_grp_no = Convert.ToInt32(StunumericUpDown2.Value);

                StutextBox2.Text = year_sem + "." + programme + "." + grp_no;
                StutextBox3.Text = year_sem + "." + programme + "." + grp_no + "." + sub_grp_no;

                MessageBox.Show("Generates IDs successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Generate IDs" + ex);
            }
        }

        private void StuLabel3_Click(object sender, EventArgs e)
        {
           

        }

        private void StuLabel2_Click(object sender, EventArgs e)
        {
            View_Student view_Student = new View_Student();
            view_Student.Show();
        }

        private void StuLabel3_Click_1(object sender, EventArgs e)
        {
            Edit_Student_GroupCs view_Student = new Edit_Student_GroupCs();
            view_Student.Show();
        }
    }
}
