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
    public partial class Edit_Subject : Form
    {
        public Edit_Subject()
        {
            InitializeComponent();
        }

        private void ScomboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query = "SELECT * from add_subject where id='" + ScomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader;

            try
            {
                conn.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    String SName = dReader.GetString("SName");
                    String SCode = dReader.GetString("SCode");
                    String SYear = dReader.GetString("SYear");
                    String SSemester = dReader.GetString("SSemester");
                    String SLecHours = dReader.GetString("SLecHours");
                    String STuteHours = dReader.GetString("STuteHours");
                    String SLabHours = dReader.GetString("SLabHours");
                    String SEvaHours = dReader.GetString("SEvaHours");
                    SEDtextBox1.Text = SName;
                    SEDtextBox2.Text = SCode;
                    SEDcomboBox1.Text = SYear;
                    SEDcomboBox2.Text = SSemester;
                    SEDnumericUpDown1.Text = SLecHours;
                    SEDnumericUpDown2.Text = STuteHours;
                    SEDnumericUpDown3.Text = SLabHours;
                    SEDnumericUpDown4.Text = SEvaHours;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void SUPDATE_Click(object sender, EventArgs e)
        {
            {
                string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
                string updateQuery = "UPDATE add_subject SET SName='" + SEDtextBox1.Text + "',SCode='" + SEDtextBox2.Text + "',SYear='" + SEDcomboBox1.Text + "',SSemester='" + SEDcomboBox2.Text + "',SLecHours='" + SEDnumericUpDown1.Text + "',STuteHours='" + SEDnumericUpDown2.Text + "',SLabHours='" + SEDnumericUpDown3.Text + "',SEvaHours='" + SEDnumericUpDown4.Text + "'where ID ='" + ScomboBoxRollNo.Text + "'";
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                MySqlDataReader mReader;

                try
                {
                    conn.Open();
                    mReader = cmd.ExecuteReader();
                    MessageBox.Show("Subject record Update successfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to update the Subject record" + ex);

                }
            }
        }

        private void SEDELETE_Click(object sender, EventArgs e)
        
        {
            view_subject view_subject = new view_subject();
            view_subject.Show();
        }

        private void SSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void SLabel1_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void SLabel3_Click(object sender, EventArgs e)
        {
            view_subject view_subject = new view_subject();
            view_subject.Show();
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

        private void SLabel2_Click(object sender, EventArgs e)
        {

            Edit_Subject Edit_Subject = new Edit_Subject();
            Edit_Subject.Show();
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
