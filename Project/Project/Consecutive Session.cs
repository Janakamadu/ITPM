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
    public partial class Consecutive_Session : Form
    {
        public Consecutive_Session()
        {
            InitializeComponent();
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void Consecutive_Session_Load(object sender, EventArgs e)
        {

            cn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root");
            da = new MySqlDataAdapter("Select * from add_session", cn);

            string selectQuery = "Select Session_ID,LName,LName2,SubjectName,SubjectCode,GroupID,tag from add_session";

            cn.Open();
            MySqlCommand command = new MySqlCommand(selectQuery, cn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader.GetString("Session_ID") +' '+ reader.GetString("LName")+' ' + reader.GetString("LName2")+' ' + reader.GetString("SubjectName")+' ' + reader.GetString("SubjectCode")+' ' + reader.GetString("GroupID")+' ' + reader.GetString("tag"));


                comboBox2.Items.Add(reader.GetString("Session_ID") + ' ' + reader.GetString("LName") + ' ' + reader.GetString("LName2") + ' ' + reader.GetString("SubjectName") + ' ' + reader.GetString("SubjectCode") + ' ' + reader.GetString("GroupID") + ' ' + reader.GetString("tag"));
            }

            cn.Close();

        }

        private void btn_Add_Consective_Session_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "INSERT INTO consective_table(session1,session2)values('" + this.comboBox1.Text + "','" + this.comboBox2.Text + "')";
                dataAdpter.excecuteSQL(sql);
                MessageBox.Show("Consective session add successfully");

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Unable add Consective session "+ex);
               
            }
        }

        private void dataGridViewConsective_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewConsective.DataSource = ds.Tables["dept"];
            DataGridViewRow row = dataGridViewConsective.Rows[e.RowIndex];
        }

        private void btn_Consective_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root");
                da = new MySqlDataAdapter("Select * from consective_table", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                dataGridViewConsective.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }

        private void btnClear_Consective_Session_Click(object sender, EventArgs e)
        {
            try
            {

                comboBox1.Text = string.Empty;
                comboBox2.Text = string.Empty;

                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void textBoxSsearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["dept"]);
            dv.RowFilter = string.Format(" session1 like '%{0}%'", textBoxSsearch.Text);

            dataGridViewConsective.DataSource = dv;
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
        private void AsCLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void AsCStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void AsCSubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void AsCTag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void AsCSession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void AsCAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void AsCWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }
        private void AsCHome_Click(object sender, EventArgs e)
        {

        }
        private void AsCRoom_Click(object sender, EventArgs e)
        {

        }

        private void AsCLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();

        }

        private void AsCStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void AsCTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }

        
    }
}
