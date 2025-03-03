﻿using System;
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
    public partial class Edit_Lecturer : Form
    {

        public Edit_Lecturer()
        {
            InitializeComponent();

        }
        private void comboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query ="SELECT * from add_lecturer where id='"+comboBoxRollNo.Text+"'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader;

            try
            {
                conn.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    String LName = dReader.GetString("LName");
                    String LEmployeeID = dReader.GetString("LEmployeeID");
                    String Faculty = dReader.GetString("Faculty");
                    String Department = dReader.GetString("Department");
                    String Center = dReader.GetString("Center");
                    String Building = dReader.GetString("Building");
                    String Level = dReader.GetString("Level");
                    String Rank_no = dReader.GetString("Rank_no");
                    EdtextBox1.Text =  LName;
                    EdtextBox2.Text =  LEmployeeID;
                    EdcomboBox1.Text = Faculty;
                    EdcomboBox2.Text = Department;
                    EdcomboBox3.Text = Center;
                    EdcomboBox4.Text = Building;
                    EdcomboBox5.Text = Level;
                    EdtextBox3.Text =  Rank_no;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }    
        private void LUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE add_lecturer SET LName='" + EdtextBox1.Text + "',LEmployeeID='" + EdtextBox2.Text + "',Faculty='" + EdcomboBox1.Text + "',Department='" + EdcomboBox2.Text + "',Center='" + EdcomboBox3.Text+"',Building='"+EdcomboBox4.Text+"',Level='"+EdcomboBox5.Text+"',Rank_no='"+EdtextBox3+"'where ID ='"+comboBoxRollNo.Text+"'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Lecture record Update successfully");

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Unable to update the lecturer record" + ex);

            }
        }

        private void LLabel3_Click(object sender, EventArgs e)
        {
            View_Lecturer view_Lecturer = new View_Lecturer();
            view_Lecturer.Show();
        }

        private void LEDELETE_Click(object sender, EventArgs e)
        {
            View_Lecturer view_Lecturer = new View_Lecturer();
            view_Lecturer.Show();

        }

        private void LLabel1_Click(object sender, EventArgs e)
        {
             Add_Lecturer add_Lecturer = new Add_Lecturer();
             add_Lecturer.Show();
           
        }

        private void LLabel2_Click(object sender, EventArgs e)
        {
            Edit_Lecturer edit_Lecturer = new Edit_Lecturer();
            edit_Lecturer.Show();
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
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
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

        private void LTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate tTLecGenereate = new TTLecGenereate();
            tTLecGenereate.Show();
        }

        private void LHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
    
}

