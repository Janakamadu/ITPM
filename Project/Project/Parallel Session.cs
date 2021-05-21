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
    public partial class Parallel_Session : Form
    {
        public Parallel_Session()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void Parallel_Session_Load(object sender, EventArgs e)
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

        private void btnAdd_Parallel_Session_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "INSERT INTO paralle_table(session1,session2,duration,days,start_time,end_time)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.comboBox6.Text + "')";
                dataAdpter.excecuteSQL(sql);
                MessageBox.Show("Parallel session add successfully");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable add Parallel session "+ex);
             
            }
        }

        private void btnView_Parallel_Session_Click(object sender, EventArgs e)
        {
            View_Parallel_Session mform = new View_Parallel_Session();
            mform.Show();
            this.Hide();
        }

        private void btnClear_Parallel_Session_Click(object sender, EventArgs e)
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

        }

        private void AdPLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void AdPStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void AdPSubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void AdPTag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void AdPSession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void AdPAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void AdPWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }
        private void AdPHome_Click(object sender, EventArgs e)
        {

        }
        private void AdPRoom_Click(object sender, EventArgs e)
        {

        }
        private void AdPLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void AdPStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void AdPTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }

      
    }
}
