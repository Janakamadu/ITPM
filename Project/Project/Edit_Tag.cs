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
    public partial class Edit_Tag : Form
    {
        public Edit_Tag()
        {
            InitializeComponent();
        }

      
        private void TagUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                DataAdpter dataAdpter = new DataAdpter();
                string sql = "UPDATE tag SET tag_name = '" + this.textBox1.Text + "',tag_code='" + this.textBox2.Text + "',related_tag ='" + this.comboBox1.Text + "'WHERE idtag ='" + label1.Text + "';";
                dataAdpter.excecuteSQL(sql);


                MessageBox.Show("Data update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Update data" + ex);
            }
        }
        private void TagClear_Click(object sender, EventArgs e)
        {
            try
            {

                textBox1.Clear();
                textBox2.Clear();
                comboBox1.Text = string.Empty;


                MessageBox.Show("Data clear successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to clear data" + ex);
            }
        }

        private void TagBack_Click(object sender, EventArgs e)
        {
            View_Tag view_Tag = new View_Tag();
            view_Tag.Show();
            this.Hide();
        }

        private void TagELabel1_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }
        private void TagELabel2_Click(object sender, EventArgs e)
        {
            View_Tag mform = new View_Tag();
            mform.Show();
            this.Hide();
        }
        private void TagELabel3_Click(object sender, EventArgs e)
        {
            Edit_Tag mform = new Edit_Tag();
            mform.Show();
            this.Hide();
        }
        private void TagELecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer mform = new Add_Lecturer();
            mform.Show();
            this.Hide();
        }

        private void TagEStudent_Click(object sender, EventArgs e)
        {
            Add_Student mform = new Add_Student();
            mform.Show();
            this.Hide();
        }

        private void TagESubject_Click(object sender, EventArgs e)
        {
            Add_Subject mform = new Add_Subject();
            mform.Show();
            this.Hide();
        }
        private void TagETag_Click(object sender, EventArgs e)
        {
            Add_Tag mform = new Add_Tag();
            mform.Show();
            this.Hide();
        }
        private void TagESession_Click(object sender, EventArgs e)
        {
            add_Session mform = new add_Session();
            mform.Show();
            this.Hide();
        }

        private void TagEAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session mform = new Consecutive_Session();
            mform.Show();
            this.Hide();
        }

        private void TagEWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours mform = new WorkingDays_Hours();
            mform.Show();
            this.Hide();
        }
        private void TagEHome_Click(object sender, EventArgs e)
        {

        }
        private void TagERoom_Click(object sender, EventArgs e)
        {

        }
        private void TagELocations_Click(object sender, EventArgs e)
        {
            Add_Location mform = new Add_Location();
            mform.Show();
            this.Hide();
        }

        private void TagEStatistics_Click(object sender, EventArgs e)
        {
            Statistic mform = new Statistic();
            mform.Show();
            this.Hide();
        }

        private void TagETimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate mform = new TTLecGenereate();
            mform.Show();
            this.Hide();
        }

        
    }
}
