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
    public partial class Add_Tag : Form
    {
        public Add_Tag()
        {
            InitializeComponent();
        }

        private void TagADD_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO tag(tag_name,tag_code,related_tag) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Tag details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }
        }

        private void TagCLEAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = string.Empty;

        }

        private void TagLabel3_Click(object sender, EventArgs e)
        {
            View_Tag view_Tag = new View_Tag();
            view_Tag.Show();
            this.Hide();
        }

        private void TagLecturer_Click(object sender, EventArgs e)
        {

            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void TagStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void TagSubject_Click(object sender, EventArgs e)
        { 
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void TagTag_Click(object sender, EventArgs e)
        {
            
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagSession_Click(object sender, EventArgs e)
        {
            
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void TagAdvanced_Click(object sender, EventArgs e)
        {
           
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void TagWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }

        private void TagLabel1_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagLabel2_Click_1(object sender, EventArgs e)
        {
            View_Tag mform = new View_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagLabel3_Click_1(object sender, EventArgs e)
        {
            Edit_Tag mform = new Edit_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagHome_Click(object sender, EventArgs e)
        {

        }

        private void TagRoom_Click(object sender, EventArgs e)
        {

        }

        private void TagLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void TagStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void TagTimeTable_Click(object sender, EventArgs e)
        {

            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }
    }
}
