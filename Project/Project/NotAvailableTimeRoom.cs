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
                MessageBox.Show("Add details succesfully");
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

        private void NotARoomCLEAR_Click(object sender, EventArgs e)
        {
            NotARoomtextBox1.Text = string.Empty;
            NotARoomcomboBox1.Text = string.Empty;
            NotARoomtextBox2.Text = string.Empty;
            NotARoomtextBox3.Text = string.Empty;
        }

        private void NotARoomTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }

        private void NotARoomStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void NotARoomLocations_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }

        private void NotARoomRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom mng = new ManageSessionRoom();
            mng.Show();
        }

        private void NotARoomSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void NotARoomTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void NotARoomSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void NotARoomStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void NotARoomLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }
    }
}
