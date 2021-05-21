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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String ConnectString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            MySqlConnection con = new MySqlConnection(ConnectString);
            MySqlDataAdapter madapter = new MySqlDataAdapter();
            madapter.SelectCommand = new MySqlCommand("Select * from new_table",con);
            MySqlCommandBuilder cmd = new MySqlCommandBuilder(madapter);

            con.Open();
            DataSet ds = new DataSet();
            MessageBox.Show("Connection with MySql database Established");

        }

        private void HWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours workingDays_Hours = new WorkingDays_Hours();
            workingDays_Hours.Show();
        }

        private void HHome_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();


        }

        private void HLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }

        private void HStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void HSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void HTag_Click(object sender, EventArgs e)
        {
            Add_Tag add_Tag = new Add_Tag();
            add_Tag.Show();
        }

        private void HSession_Click(object sender, EventArgs e)
        {
            add_Session Add_session = new add_Session();
            Add_session.Show();
        }

        private void HAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void HRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void HLocations_Click(object sender, EventArgs e)
        {

            Add_Location add_Location = new Add_Location();
            add_Location.Show();
        }

        private void HStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void HTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate tTLecGenereate = new TTLecGenereate();
            tTLecGenereate.Show();
        }
    }
}
