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
            StudataGridViewLecturer.DataSource = ds.Tables["dept"];
        }

        private void StuDELETE_Click(object sender, EventArgs e)
        {
            try
            {

                DataAdpter dataAdpter = new DataAdpter();
                String sql = "DELETE FROM student WHERE idstudent = '" + label1.Text + "';" ;
                dataAdpter.excecuteSQL(sql);
                StudataGridViewLecturer.Refresh();

                MessageBox.Show("Data delete successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to data delete" + ex);
            }
        }

        
    private void StudataGridViewLecturer_CellClik(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = StudataGridViewLecturer.Rows[e.RowIndex];
            label1.Text = row.Cells[0].Value.ToString();
        }

        

        private void textBoxStsearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(ds.Tables["dept"]);
            dv.RowFilter = string.Format("grp_no like '%{0}%'", StutextBoxsearch.Text);

            StudataGridViewLecturer.DataSource = dv;
        }

        private void StuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void StudataGridViewLecturer_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Student_GroupCs f2 = new Edit_Student_GroupCs();
            f2.label7.Text = this.StudataGridViewLecturer.CurrentRow.Cells[0].Value.ToString();
            f2.StutextBox1.Text = this.StudataGridViewLecturer.CurrentRow.Cells[1].Value.ToString();
            f2.StucomboBox1.Text = this.StudataGridViewLecturer.CurrentRow.Cells[2].Value.ToString();
            f2.StunumericUpDown1.Text = this.StudataGridViewLecturer.CurrentRow.Cells[3].Value.ToString();
            f2.StunumericUpDown2.Text = this.StudataGridViewLecturer.CurrentRow.Cells[4].Value.ToString();
            f2.StutextBox2.Text = this.StudataGridViewLecturer.CurrentRow.Cells[5].Value.ToString();
            f2.StutextBox3.Text = this.StudataGridViewLecturer.CurrentRow.Cells[6].Value.ToString();
            f2.ShowDialog();
        }
    }
    
}
