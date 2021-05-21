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
    public partial class Edit_Session : Form
    {
        public Edit_Session()
        {
            InitializeComponent();
        }
      

        private void SesDELETE_Click(object sender, EventArgs e)
        {
            View_Session view_Session = new View_Session();
            view_Session.Show();
        }

        private void SescomboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query = "SELECT * from add_session where Session_ID='" + SescomboBoxRollNo.Text + "'";
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
                    String LName2 = dReader.GetString("LName2");
                    String SubjectName = dReader.GetString("SubjectName");
                    String SubjectCode = dReader.GetString("SubjectCode");
                    String GroupID = dReader.GetString("GroupID");
                    String tag = dReader.GetString("tag");
                    String NoOfStudent = dReader.GetString("NoOfStudent");
                    String Duration = dReader.GetString("Duration");
                    String GenerateSession = dReader.GetString("GenerateSession");

                    SesEcomboBox1.Text = LName;
                    SesEtextBox1.Text = LName2;
                    SesEcomboBox2.Text = SubjectName;
                    SesEcomboBox3.Text = SubjectCode;
                    SesEcomboBox4.Text = GroupID;
                    SesEcomboBox5.Text = tag;
                    SesEtextBox2.Text = NoOfStudent;
                    SesEtextBox3.Text = Duration;
                    SesEtextBox4.Text = GenerateSession;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void SesUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE add_session SET LName='" + SesEcomboBox1.Text + "',LName2='" + SesEtextBox1.Text + "',SubjectName='" + SesEcomboBox2.Text + "',SubjectCode='" + SesEcomboBox3.Text + "',GroupID='" + SesEcomboBox4.Text + "',tag='" + SesEcomboBox5.Text + "',NoOfStudent='" + SesEtextBox2.Text + "',Duration='" + SesEtextBox3 + "',GenerateSession='" + SesEtextBox4 + "'where Session_ID ='" + SescomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Session record Update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the Session record" + ex);

            }
        }

        private void LStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void LSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
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

        private void SesLabel1_Click(object sender, EventArgs e)
        {
            add_Session add_Session = new add_Session();
            add_Session.Show();
        }

        private void SesLabel2_Click(object sender, EventArgs e)
        {
            Edit_Session edit_Session = new Edit_Session();
            edit_Session.Show();
        }

        private void SesLabel3_Click(object sender, EventArgs e)
        {
            View_Session view_Session = new View_Session();
            view_Session.Show();
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
