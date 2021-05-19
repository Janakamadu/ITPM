using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Edit_Student_GroupCs : Form
    {
        public Edit_Student_GroupCs()
        {
            InitializeComponent();
        }

        private void StuGenerate_Click(object sender, EventArgs e)
        {
            try
            {

                String year_sem = StutextBox1.Text;
                String programme = StucomboBox1.Text;

                int grp_no = Convert.ToInt32(StunumericUpDown1.Value);
                int sub_grp_no = Convert.ToInt32(StunumericUpDown2.Value);

                StutextBox2.Text = year_sem + "." + programme + "." + grp_no;
                StutextBox3.Text = year_sem + "." + programme + "." + grp_no + "." + sub_grp_no;

                MessageBox.Show("Generates IDs successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Generate IDs" + ex);
            }
        }

        private void StuUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "UPDATE student SET year_sem = '" + this.StutextBox1.Text + "',programme='" + this.StucomboBox1.Text + "',grp_no ='" + this.StunumericUpDown1.Text + "',sub_grp_no ='" + this.StunumericUpDown2.Text + "',grp_id ='" + this.StutextBox2.Text + "',sub_grp_id ='" + this.StutextBox3.Text + "'WHERE idstudent ='" + label7.Text + "';";
                dataAdpter.excecuteSQL(sql);
               

                MessageBox.Show("Data update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }

        private void StuClear_Click(object sender, EventArgs e)
        {
            try
            {

                StutextBox1.Clear();
                StucomboBox1.Text = string.Empty;
                StunumericUpDown1.Value = 0;
                StunumericUpDown2.Value = 0;
                StutextBox2.Clear();
                StutextBox3.Clear();

                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void StuBack_Click(object sender, EventArgs e)
        {
            View_Student mform = new View_Student();
            mform.Show();
        }
    }
}
