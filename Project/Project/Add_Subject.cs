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
    public partial class Add_Subject : Form
    {
        public Add_Subject()
        {
            InitializeComponent();
        }

        private void SADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO add_subject(SName,SCode,SYear,SSemester,SLecHours,STuteHours,SLabHours,SEvaHours) values('" + this.StextBox1.Text + "','" + this.StextBox2.Text + "','" + this.ScomboBox1.Text + "','" +this.ScomboBox2.Text+"','" + this.numericUpDown1.Text + "','" + this.numericUpDown2.Text + "','" + this.numericUpDown3.Text + "','" + this.numericUpDown4.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Subject details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }

        }

        private void SLabel3_Click(object sender, EventArgs e)
        {
            view_subject view_subject = new view_subject();
            view_subject.Show();
        }

        private void SSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void SLabel2_Click(object sender, EventArgs e)
        {

            Edit_Subject Edit_Subject = new Edit_Subject();
            Edit_Subject.Show();
        }

        private void SCLEAR_Click(object sender, EventArgs e)
        {
            StextBox1.Text = string.Empty;
            StextBox2.Text = string.Empty;
            ScomboBox1.Text = string.Empty;
            ScomboBox2.Text = string.Empty;
            numericUpDown1.Text = string.Empty;
            numericUpDown2.Text = string.Empty;
            numericUpDown3.Text = string.Empty;
            numericUpDown4.Text = string.Empty;
        }

        private void LStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void LTag_Click(object sender, EventArgs e)
        {
            Add_Tag add_Tag = new Add_Tag();
            add_Tag.Show();
        }

        private void LSession_Click(object sender, EventArgs e)
        {
            add_Session Add_session = new add_Session();
            Add_session.Show();
        }

        private void LAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void LWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours workingDays_Hours = new WorkingDays_Hours();
            workingDays_Hours.Show();
        }

        private void LRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void LLocations_Click(object sender, EventArgs e)
        {

            Add_Location add_Location = new Add_Location();
            add_Location.Show();
        }

        private void LStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void SLabel1_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void LTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate tTLecGenereate = new TTLecGenereate();
            tTLecGenereate.Show();
        }

        private void LHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
