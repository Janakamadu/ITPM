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
    public partial class add_Session : Form
    {
        public add_Session()
        {
            InitializeComponent();
            displayData();
            displayData1();
            displayData2();
            displayData3();

        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM add_lecturer";
            string displayQuery1 = " SELECT * FROM add_subject";
            string displayQuery2 = " SELECT * FROM add_subject";
            string displayQuery3 = " SELECT * FROM student";
    
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd1 = new MySqlCommand(displayQuery, con);
            MySqlCommand cmd2 = new MySqlCommand(displayQuery, con);
            MySqlCommand cmd3= new MySqlCommand(displayQuery, con);
            MySqlCommand cmd4 = new MySqlCommand(displayQuery, con);
          
            MySqlDataReader dataReader;
            try
            {
                con.Open();
                dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    String LName = dataReader.GetString("LName");
                    SesLcomboBox1.Items.Add(LName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }

        }
        void displayData1()
        {
            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery1 = " SELECT * FROM add_subject";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd2 = new MySqlCommand(displayQuery1, con);


            MySqlDataReader reader1;

            try
            {
                con.Open();
                reader1 =cmd2.ExecuteReader();



                while (reader1.Read())
                {
                    String SName = reader1.GetString("SName");
                    SesLcomboBox2.Items.Add(SName);


                }

            }
            catch (Exception e)
            {

            }
        }

        void displayData2()
        {
            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery2 = " SELECT * FROM add_subject";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd3 = new MySqlCommand(displayQuery2, con);


            MySqlDataReader reader2;

            try
            {
                con.Open();
                reader2 = cmd3.ExecuteReader();



                while (reader2.Read())
                {
                    String SCode = reader2.GetString("SCode");
                    SesLcomboBox3.Items.Add(SCode);


                }

            }
            catch (Exception e)
            {

            }
        }

        void displayData3()
        {
            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery3 = " SELECT * FROM student";

            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd4 = new MySqlCommand(displayQuery3, con);


            MySqlDataReader reader3;

            try
            {
                con.Open();
                reader3 = cmd4.ExecuteReader();



                while (reader3.Read())
                {
                    String grp_id = reader3.GetString("grp_id");
                    SesLcomboBox4.Items.Add(grp_id);


                }

            }
            catch (Exception e)
            {

            }
        }

        private void add_Session_Load(object sender, EventArgs e)
        {

        }

        private void SesSubmit_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO add_session(LName,LName2,SubjectName,SubjectCode,GroupID,tag,NoOfStudent,Duration,GenerateSession) values('" + this.SesLcomboBox1.Text + "','" + this.SesLtextBox1.Text + "','" + this.SesLcomboBox2.Text + "','" + this.SesLcomboBox3.Text + "','" + this.SesLcomboBox4.Text + "','" + this.SesLcomboBox5.Text + "','" + this.SesLtextBox2.Text + "','" + this.SesLtextBox3.Text + "','" + this.SesLtextBox4.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Session details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }
        }

        private void SesLcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SesGenerate_Click(object sender, EventArgs e)
        {
            String LName = SesLcomboBox1.Text;
            String LName2 = SesLtextBox1.Text;
            String SubjectName = SesLcomboBox2.Text;
            String SubjectCode = SesLcomboBox3.Text;
            String GroupID = SesLcomboBox4.Text;
            String tag = SesLcomboBox5.Text;
            String NoOfStudent = SesLtextBox2.Text;
            String Duration = SesLtextBox3.Text;


            SesLtextBox4.Text = LName + " - " + LName2 + " - " +SubjectCode + " - " +SubjectName + " - " +tag + " - " +GroupID + " - " +NoOfStudent + " - " + Duration;
        }

        private void SesLabel3_Click(object sender, EventArgs e)
        {
            View_Session view_Session = new View_Session();
            view_Session.Show();

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

        private void SesCLEAR_Click(object sender, EventArgs e)
        {
            SesLcomboBox1.Text = string.Empty;
            SesLtextBox1.Text = string.Empty;
            SesLcomboBox2.Text = string.Empty;
            SesLcomboBox3.Text = string.Empty;
            SesLcomboBox4.Text = string.Empty;
            SesLcomboBox5.Text = string.Empty;
            SesLtextBox2.Text = string.Empty;
            SesLtextBox3.Text = string.Empty;
            SesLtextBox4.Text = string.Empty;
        }

        private void SesLabel2_Click(object sender, EventArgs e)
        {
            Edit_Session edit_Session = new Edit_Session();
            edit_Session.Show();
        }

        private void SesLabel1_Click(object sender, EventArgs e)
        {
            add_Session add_Session = new add_Session();
            add_Session.Show();
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
