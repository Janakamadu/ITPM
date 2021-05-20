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

        private void comboBoxLocationID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LocDLabel3_Click(object sender, EventArgs e)
        {
            Edit_Location el = new Edit_Location();
            el.Show();
        }

        private void LocDLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void LocDStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void LocDSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void LocDTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void LocDSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void LocDWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
        }

        private void LocDRoom_Click(object sender, EventArgs e)
        {
            ManageSession2 manageSession2 = new ManageSession2();
            manageSession2.Show();
        }

        private void LocDStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void LocDLocations_Click(object sender, EventArgs e)
        {

        }

        private void LocDTimeTable_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }
    }
}
