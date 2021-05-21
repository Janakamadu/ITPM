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
    public partial class Non_Overlapping_Session : Form
    {
        public Non_Overlapping_Session()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void Non_Overlapping_Session_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root");
            da = new MySqlDataAdapter("Select * from add_session", cn);

            string selectQuery = "Select Session_ID,LName,LName2,SubjectName,SubjectCode,GroupID,tag from add_session";

            cn.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, cn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("Session_ID") + ' ' + reader.GetString("LName") + ' ' + reader.GetString("LName2") + ' ' + reader.GetString("SubjectName") + ' ' + reader.GetString("SubjectCode") + ' ' + reader.GetString("GroupID") + ' ' + reader.GetString("tag"));


                comboBox2.Items.Add(reader.GetString("Session_ID") + ' ' + reader.GetString("LName") + ' ' + reader.GetString("LName2") + ' ' + reader.GetString("SubjectName") + ' ' + reader.GetString("SubjectCode") + ' ' + reader.GetString("GroupID") + ' ' + reader.GetString("tag"));
            }

            cn.Close();
        }

     
        private void btnAdd_NonOverlap_Session_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "INSERT INTO nonoverlap_table(session1,session2,duration,days,start_time,end_time)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.comboBox6.Text + "')";
                dataAdpter.excecuteSQL(sql);
                MessageBox.Show("Non Overlap session add successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable add NonOverlap session ");
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnClear_NonOverlap_Session_Click(object sender, EventArgs e)
        {
            try
            {

                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;
                comboBox3.Text = string.Empty;
                comboBox4.Text = string.Empty;
                comboBox5.Text = string.Empty;
                comboBox6.Text = string.Empty;


                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void btnLabel_Consective_Session_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void btnLabel_PArallel_Session_Click(object sender, EventArgs e)
        {
            Parallel_Session mform = new Parallel_Session();
            mform.Show();
            this.Hide();
        }

        private void btnLabel_NonOverlap_Session_Click(object sender, EventArgs e)
        {
            Non_Overlapping_Session mform = new Non_Overlapping_Session();
            mform.Show();
            this.Hide();
        }
        
        private void btnLabel_NotAvailableTime_Session_Click(object sender, EventArgs e)
        {
            NotAvailableSession notAvailableSession = new NotAvailableSession();
            notAvailableSession.Show();
        }

        private void LLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void LStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void LSubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void LTag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void LSession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void LAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void LWorking_Click(object sender, EventArgs e)
        {

            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }
        private void LHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
        private void LRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }
        private void LLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void LStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void LTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }
        private void NonOverlapping_View_Click(object sender, EventArgs e)
        {
            View_Non_Overlapping_Session mform = new View_Non_Overlapping_Session();
            mform.Show();
            this.Hide();
        }
    }
}
