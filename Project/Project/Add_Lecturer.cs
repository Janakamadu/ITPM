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
    public partial class Add_Lecturer : Form
    {
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        private void LLabl_Click(object sender, EventArgs e)
        {

        }

        private void LRank_Click(object sender, EventArgs e)
        {

        }

        private void LBuilding_Click(object sender, EventArgs e)
        {

        }

        private void LADD_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery ="INSERT INTO add_lecturer(LName,LEmployeeID,Faculty,Department,Center,Building,Level,Rank_no) values('"+this.LtextBox1.Text+"','"+this.LtextBox2.Text+"','"+this.LcomboBox1.Text+"','"+this.LcomboBox2.Text+"','"+this.LcomboBox3.Text+"','"+this.LcomboBox4.Text+"','"+this.LcomboBox5.Text+"','"+this.LtextBox3.Text+"')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery,con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Lecturer details succesfully");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Unabe the Data insert due to " +ex );
                
            }

        }

        private void LGenerate_Click(object sender, EventArgs e)
        {
            string EmployeeID = LtextBox2.Text;
            string Level      = LcomboBox5.Text;

            LtextBox3.Text = EmployeeID + "."+ Level;
      
        }

        private void LGenerate_Click_1(object sender, EventArgs e)
        {
            String EmployeeID = LtextBox2.Text;
            String Level = LcomboBox5.Text;

            LtextBox3.Text = EmployeeID + "." + Level;
       
        }

        private void LLabel3_Click(object sender, EventArgs e)
        {
            View_Lecturer view_Lecturer = new View_Lecturer();
            view_Lecturer.Show();


        }

        private void LSubject_Click(object sender, EventArgs e)
        {
            Add_Subject Add_Subject = new Add_Subject();
            Add_Subject.Show();
        }

        private void LLabel2_Click(object sender, EventArgs e)
        {
            Edit_Lecturer Edit_Lecturer = new Edit_Lecturer();
            Edit_Lecturer.Show();
        }

        private void LCLEAR_Click(object sender, EventArgs e)
        {
            LtextBox1.Text = string.Empty;
            LtextBox2.Text = string.Empty;
            LcomboBox1.Text = string.Empty;
            LcomboBox2.Text = string.Empty;
            LcomboBox3.Text = string.Empty;
            LcomboBox4.Text = string.Empty;
            LcomboBox5.Text = string.Empty;
            LtextBox3.Text = string.Empty;



        }

        private void LSession_Click(object sender, EventArgs e)
        {
            add_Session Add_session = new add_Session();
            Add_session.Show();

        }

        private void LLocations_Click(object sender, EventArgs e)
        {
            Add_Location add_Location = new Add_Location();
            add_Location.Show();
        }

        private void LAdvanced_Click(object sender, EventArgs e)
        {
           
        }

        private void LWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours workingDays_Hours = new WorkingDays_Hours();
            workingDays_Hours.Show();

        }

        private void LStudent_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void LTag_Click(object sender, EventArgs e)
        {
            Add_Tag add_Tag = new Add_Tag();
            add_Tag.Show();
        }

        private void LRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
            manageSessionRoom.Show();
        }

        private void LStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void LLabel1_Click(object sender, EventArgs e)
        {
            Add_Lecturer add_Lecturer = new Add_Lecturer();
            add_Lecturer.Show();
        }
    }
}
