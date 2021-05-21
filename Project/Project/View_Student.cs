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
    public partial class View_Student : Form
    {
        public View_Student()
        {
            InitializeComponent();
           
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void View_Student_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = itpm_project; password = root");
            da = new MySqlDataAdapter("Select * from student", cn);


            ds = new DataSet();
            da.Fill(ds, "dept");
            StudataGridView.DataSource = ds.Tables["dept"];
        }

        private void StuDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                DataAdpter dataAdpter = new DataAdpter();
                String sql = "DELETE FROM student WHERE idstudent = '" + label1.Text + "';" ;
                dataAdpter.excecuteSQL(sql);
                StudataGridView.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to data delete" + ex);
            }
        }

        private void StudataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = StudataGridView.Rows[e.RowIndex];
            label1.Text = row.Cells[0].Value.ToString();
        }


        private void textBoxStsearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["dept"]);
            dv.RowFilter = string.Format("grp_no like '%{0}%'", StutextBoxsearch.Text);

            StudataGridView.DataSource = dv;
        }


        private void StudataGridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Student_GroupCs f2 = new Edit_Student_GroupCs();
            this.Hide();
            f2.label7.Text = this.StudataGridView.CurrentRow.Cells[0].Value.ToString();
            f2.StutextBox1.Text = this.StudataGridView.CurrentRow.Cells[1].Value.ToString();
            f2.StucomboBox1.Text = this.StudataGridView.CurrentRow.Cells[2].Value.ToString();
            f2.StunumericUpDown1.Text = this.StudataGridView.CurrentRow.Cells[3].Value.ToString();
            f2.StunumericUpDown2.Text = this.StudataGridView.CurrentRow.Cells[4].Value.ToString();
            f2.StutextBox2.Text = this.StudataGridView.CurrentRow.Cells[5].Value.ToString();
            f2.StutextBox3.Text = this.StudataGridView.CurrentRow.Cells[6].Value.ToString();
            f2.ShowDialog();
           
        }
        private void StuRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root");
                da = new MySqlDataAdapter("Select * from student", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                StudataGridView.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }
        private void StuLabel1_Click(object sender, EventArgs e)
        {

            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }


        private void StuLabel2_Click(object sender, EventArgs e)
        {
            View_Student mform = new View_Student();
            mform.Show();
            this.Hide();
        }

        private void StuLabel3_Click(object sender, EventArgs e)
        {
            Edit_Student_GroupCs mform = new Edit_Student_GroupCs();
            mform.Show();
            this.Hide();
        }

        private void StuLecturer_Click(object sender, EventArgs e)
        {

            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void StuStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void StuSubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void StuTag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void StuSession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void StuAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void StuWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }

        private void StuHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void StuRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void StuLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void StuStatistics_Click(object sender, EventArgs e)
        {

            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void StuTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }
    }
    
}
