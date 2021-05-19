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
