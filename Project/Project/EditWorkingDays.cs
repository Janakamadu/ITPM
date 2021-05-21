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

    public partial class EditWorkingDays : Form
    {
        public string monday, tuesday, wednesday, thursday, friday, saturday, sunday;
        public int getOnlyReccordIDValue;

        public EditWorkingDays()
        {
            InitializeComponent();
        }

        private void WDUPDATE_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string Query = "update addworkintable set NoOfWorkingDays='" + this.EnoOfWorkingDays.Text + "',Monday='" + monday + "',Tuesday='" + tuesday + "',Wednesday='" + wednesday + "',Thursday='" + thursday + "',Friday='" + friday + "',Saturday='" + saturday + "',Sunday='" + sunday + "',addHrs='" + this.EaddHrs.Text + "',addMin='" + this.EaddMin.Text + "' where ID='" + this.recordID.Text + "'";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;

            try
            {
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Successfull to update data");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update data" + ex);
            }


        }

        private void EmondayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EmondayCheckBox.Checked)
            {
                monday = "Monday";
            }
            else
            {
                monday = "not Working";
            }
        }

        private void EtuesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EtuesdayCheckBox.Checked)
            {
                tuesday = "Tuesday";
            }
            else
            {
                tuesday = "not Working";
            }

        }

        private void WDEDELETE_Click(object sender, EventArgs e)
        {
            ViewWorkingDays WD= new ViewWorkingDays();
            WD.Show();
        }

        private void WDELecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void WDEStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void WDESubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void WDETag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void WDESession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void WDERoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom mng = new ManageSessionRoom();
            mng.Show();
        }

        private void WDELocations_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }

        private void WDEStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void WDETimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }

        private void WDEAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void WDEHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void EwednesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EwednesdayCheckBox.Checked)
            {
                wednesday = "Wednesday";
            }
            else
            {
                wednesday = "not Working";
            }


        }

        private void EthursdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EthursdayCheckBox.Checked)
            {
                thursday = "Thursday";
            }
            else
            {
                thursday = "not Working";
            }

        }

        private void EfridayCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (EfridayCheckBox.Checked)
            {
                friday = "Friday";
            }
            else
            {
                friday = "not Working";
            }
        }

        private void EsaturdayheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EsaturdayheckBox.Checked)
            {
                saturday = "Saturday";
            }
            else
            {
                saturday = "not Working";
            }
        }

        private void EsundayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EsundayCheckBox.Checked)
            {
                sunday = "Sunday";
            }
            else
            {
                sunday = "not Working";
            }

        }

        private void recordID_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
