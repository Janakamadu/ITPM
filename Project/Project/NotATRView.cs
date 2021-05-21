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
    public partial class NotATRView : Form
    {
        public NotATRView()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM roomnot";
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
                NATRdataGridView1.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }

        private void NATREDIT_Click(object sender, EventArgs e)
        {

        }

        private void NATRDELETE_Click(object sender, EventArgs e)
        {
            NATRDelete nATRDelete = new NATRDelete();
            nATRDelete.Show();
        }

        private void NATRVRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void NATRVLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }

        private void NATRVStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void NATRVSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void NATRVTag_Click(object sender, EventArgs e)
        {
            Add_Tag add_Tag = new Add_Tag();
            add_Tag.Show();
        }

        private void NATRVSession_Click(object sender, EventArgs e)
        {
            add_Session Add_session = new add_Session();
            Add_session.Show();
        }

        private void NATRVAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void NATRVWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours workingDays_Hours = new WorkingDays_Hours();
            workingDays_Hours.Show();
        }

        private void NATRVLocations_Click(object sender, EventArgs e)
        {
            Add_Location add_Location = new Add_Location();
            add_Location.Show();
        }

        private void NATRVStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void NATRVTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate tTLecGenereate = new TTLecGenereate();
            tTLecGenereate.Show();
        }

        private void NATRVHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
