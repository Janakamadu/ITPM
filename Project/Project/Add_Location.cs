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
    public partial class Add_Location : Form
    {
        public Add_Location()
        {
            InitializeComponent();
        }

        private void LocAADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO location(buildingNameComboBox,textRoomName,capacityComboBox,roomType) values('" + this.LocAcomboBox1.Text + "','" + this.LocAtextBox1.Text + "','" + this.LocAcomboBox2.Text + "','" + this.LocAcomboBox3.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Location details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }
        }

        private void LocALabel3_Click(object sender, EventArgs e)
        {
            View_Location view_Location = new View_Location();
            view_Location.Show();
        }

        private void LocAStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void LocARoom_Click(object sender, EventArgs e)
        {
            ManageSession2 manageSession2 = new ManageSession2();
            manageSession2.Show();
        }

        private void LocACLEAR_Click(object sender, EventArgs e)
        {
            LocAcomboBox1.Text = string.Empty;
            LocAtextBox1.Text = string.Empty;
            LocAcomboBox2.Text = string.Empty;
            LocAcomboBox3.Text = string.Empty;
            
        }

        private void LocALabel2_Click(object sender, EventArgs e)
        {
            Edit_Location edit = new Edit_Location();
            edit.Show();
        }

        private void LocALecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void LocAStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void LocASubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void LocATag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void LocASession_Click(object sender, EventArgs e)
        {
            add_Session  ass = new add_Session();
            ass.Show();
        }

        private void LocAWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
        }

        private void LocALocations_Click(object sender, EventArgs e)
        {
           
        }

        private void LocATimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }
    }
    }

