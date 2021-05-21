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
    public partial class WorkingDays_Hours : Form
    {
        public string monday, tuesday, wednesday, thursday, friday, saturday, sunday;

        private void saturdayheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saturdayheckBox.Checked)
            {
                saturday = "Saturday";
            }
            else
            {
                saturday = "not Working";
            }
        }

        private void fridayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fridayCheckBox.Checked)
            {
                friday = "Friday";
            }
            else
            {
                friday = "not Working";
            }
        }

        private void thursdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thursdayCheckBox.Checked)
            {
                thursday = "Thursday";
            }
            else
            {
                thursday = "not Working";
            }

        }

        private void WDADD_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
                string Query = "insert into addworkintable(NoOfWorkingDays,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,addHrs,addMin) values('" + this.noOfWorkingDays.Text + "' , '" + monday + "' , '" + tuesday + "' , '" + wednesday + "' , '" + thursday + "' , '" + friday + "' , '" + saturday + "' , '" + sunday + "' , '" + this.addHrs.Text + "' , '" + this.addMin.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WDLabel3_Click(object sender, EventArgs e)
        {
            ViewWorkingDays viewWorkingDays = new ViewWorkingDays();
            viewWorkingDays.Show();
        }

        private void WDLabel2_Click(object sender, EventArgs e)
        {
            EditWorkingDays editWorkingDays = new EditWorkingDays();
            editWorkingDays.Show();
        }

        private void WDCLEAR_Click(object sender, EventArgs e)
        {
           
            noOfWorkingDays.Text = string.Empty;
            mondayCheckBox.Checked = false;
            tuesdayCheckBox.Checked = false;
            wednesdayCheckBox.Checked = false;
            thursdayCheckBox.Checked = false;
            fridayCheckBox.Checked = false;
            saturdayheckBox.Checked = false;
            sundayCheckBox.Checked = false;
            addHrs.Text = string.Empty;
            addMin.Text = string.Empty;
        }

        private void WDLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void WDStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void WDSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void WDTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void WDSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void WDLocations_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }

        private void WDStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void WDTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }

        private void WDRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom mng = new ManageSessionRoom();
            mng.Show();
        }

        private void WDAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void WDHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void tuesdayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tuesdayCheckBox.Checked)
            {
                tuesday = "Tuesday";
            }
            else
            {
                tuesday = "not Working";
            }
        }

        private void WDcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (wednesdayCheckBox.Checked)
            {
                wednesday = "Wednesday";
            }
            else
            {
                wednesday = "not Working";
            }

        }

        private void WDcheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (sundayCheckBox.Checked)
            {
                sunday = "Sunday";
            }
            else
            {
                sunday = "not Working";
            }
        }

        public int getOnlyReccordIDValue;
        public WorkingDays_Hours()
        {
            InitializeComponent();
        }

        private void WDcheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (mondayCheckBox.Checked)
            {
                monday = "Monday";
            }
            else
            {
                monday = "not Working";
            }
        }
    }
}
