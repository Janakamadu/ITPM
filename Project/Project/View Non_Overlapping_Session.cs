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
    public partial class View_Non_Overlapping_Session : Form
    {
        public View_Non_Overlapping_Session()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        private void View_Non_Overlapping_Session_Load(object sender, EventArgs e)
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

        private void dataGridViewNonoverlapping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNonoverlapping.Rows[e.RowIndex];
            label11.Text = row.Cells[0].Value.ToString();
            comboBox1.Text = row.Cells[1].Value.ToString();
            comboBox2.Text = row.Cells[2].Value.ToString();
            comboBox3.Text = row.Cells[3].Value.ToString();
            comboBox4.Text = row.Cells[4].Value.ToString();
            comboBox5.Text = row.Cells[5].Value.ToString();
            comboBox6.Text = row.Cells[6].Value.ToString();
        }

        private void btnUpdate_NonOverlappingView_Session_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "UPDATE nonoverlap_table SET session1 = '" + this.comboBox1.Text + "',session2='" + this.comboBox2.Text + "',duration ='" + this.comboBox3.Text + "',days ='" + this.comboBox4.Text + "',start_time ='" + this.comboBox5.Text + "',end_time ='" + this.comboBox6.Text + "'WHERE id ='" + label11.Text + "';";
                dataAdpter.excecuteSQL(sql);
                dataGridViewNonoverlapping.Refresh();

                MessageBox.Show("Data update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void btnDelete_NonOverlappingView_Session_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                String sql = "DELETE FROM nonoverlap_table WHERE id ='" + label11.Text + "';";
                dataAdpter.excecuteSQL(sql);
                dataGridViewNonoverlapping.Refresh();

                MessageBox.Show("Delete successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Delete" + ex);
            }
        }

        private void btnRefresh_NonoverlappingView_Session_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root");
                da = new MySqlDataAdapter("Select * from nonoverlap_table", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                dataGridViewNonoverlapping.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["dept"]);
            dv.RowFilter = string.Format(" session1 like '%{0}%'", textBox1.Text);

            dataGridViewNonoverlapping.DataSource = dv;
        }
        private void btnBack_NonOverlappingView_Session_Click(object sender, EventArgs e)
        {
            Non_Overlapping_Session mform = new Non_Overlapping_Session();
            mform.Show();
            this.Hide();
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

    }
}
