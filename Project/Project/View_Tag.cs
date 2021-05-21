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
    public partial class View_Tag : Form
    {
        public View_Tag()
        {
            InitializeComponent();
            
        }
        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;

        private void View_Tag_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = itpm_project; password = root");
            da = new MySqlDataAdapter("Select * from tag", cn);


            ds = new DataSet();
            da.Fill(ds, "dept");
            dataGridViewTag.DataSource = ds.Tables["dept"];
        }
        private void btn_TagDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                String sql = "DELETE FROM tag WHERE idtag ='" + label1.Text + "';";
                dataAdpter.excecuteSQL(sql);
                dataGridViewTag.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to data delete" + ex);
            }
        }

        private void textBoxSsearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["dept"]);
            dv.RowFilter = string.Format("tag_name like '%{0}%'", textBoxSsearch.Text);


            dataGridViewTag.DataSource = dv;
        }
        private void dataGridViewTag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewTag.Rows[e.RowIndex];
            label1.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridViewTag_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Tag f2 = new Edit_Tag();
            this.Hide();
            f2.label1.Text = this.dataGridViewTag.CurrentRow.Cells[0].Value.ToString();
            f2.textBox1.Text = this.dataGridViewTag.CurrentRow.Cells[1].Value.ToString();
            f2.textBox2.Text = this.dataGridViewTag.CurrentRow.Cells[2].Value.ToString();
            f2.comboBox1.Text = this.dataGridViewTag.CurrentRow.Cells[3].Value.ToString();
            f2.ShowDialog();
        }
        private void btnTagRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = itpm_project; password = root");
                da = new MySqlDataAdapter("Select * from tag", cn);
                ds = new DataSet();
                da.Fill(ds, "dept");
                dataGridViewTag.DataSource = ds.Tables["dept"];

                MessageBox.Show("Refresh successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Refresh" + ex);
            }
        }
        private void TagLabel1_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagLabel2_Click(object sender, EventArgs e)
        {
            View_Tag mform = new View_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagLabel3_Click(object sender, EventArgs e)
        {
            Edit_Tag mform = new Edit_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagVLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void TagVStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void TagVSubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }

        private void TagVTag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }

        private void TagVSession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void TagVAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void TagVWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }

        private void TagVLocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void TagVStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void TagVTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }

        private void TagVRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void TagVHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
