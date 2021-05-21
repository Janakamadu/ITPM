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
    public partial class View_Location : Form
    {
        public View_Location()
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
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = cmd;
                DataTable stTable = new DataTable();
                myAdapter.Fill(stTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = stTable;
                dataGridViewLocation.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }

        private void LocEDIT_Click(object sender, EventArgs e)
        {
            Edit_Location edit_Location = new Edit_Location();
            edit_Location.Show();
        }

        private void LocDELETE_Click(object sender, EventArgs e)
        {

            Delete_Location delete_Location = new Delete_Location();
            delete_Location.Show();

        }

        private void LocALabel3_Click(object sender, EventArgs e)
        {

        }

        private void LocVLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void LocVStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void LocVSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void LocVTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void LocVSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void LocVWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
        }

        private void LocVRoom_Click(object sender, EventArgs e)
        {
            ManageSession2 manageSession2 = new ManageSession2();
            manageSession2.Show();
        }

        private void LocVStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void LocVAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void LocVTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate tTLecGenereate = new TTLecGenereate();
            tTLecGenereate.Show();
        }

        private void LocVHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
