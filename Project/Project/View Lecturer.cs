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
    public partial class View_Lecturer : Form
    {
        
        public View_Lecturer()
        {
            InitializeComponent();
            displayData();
           
        }
        public void displayData() {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM add_lecturer";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery,con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();
            
            try
            {
                myAdapter.SelectCommand = cmd;
                DataTable stTable = new DataTable();
                myAdapter.Fill(stTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = stTable;
                dataGridViewLecturer.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void LEDIT_Click(object sender, EventArgs e)
        {
            Edit_Lecturer edit_Lecturer = new Edit_Lecturer();
            edit_Lecturer.Show();

        }

        private void LDELETE_Click_1(object sender, EventArgs e)
        {
            Delete_lecturer Delete_lecturer = new Delete_lecturer();
            Delete_lecturer.Show();
        }

        private void LLabel1_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }

        private void LLabel2_Click(object sender, EventArgs e)
        {

            Edit_Lecturer Edit_Lecturer = new Edit_Lecturer();
            Edit_Lecturer.Show();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void LStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void LSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void LTag_Click(object sender, EventArgs e)
        {
            Add_Tag add_Tag = new Add_Tag();
            add_Tag.Show();
        }

        private void LSession_Click(object sender, EventArgs e)
        {
            add_Session Add_session = new add_Session();
            Add_session.Show();
        }

        private void LAdvanced_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void LWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours workingDays_Hours = new WorkingDays_Hours();
            workingDays_Hours.Show();
        }

        private void LRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void LLocations_Click(object sender, EventArgs e)
        {

            Add_Location add_Location = new Add_Location();
            add_Location.Show();
        }

        private void LStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }
    }
}
