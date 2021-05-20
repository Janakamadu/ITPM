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
    public partial class Consecutive : Form
    {
        public Consecutive()
        {
            InitializeComponent();
            FillCombobox();
            FillCombobox1();
            FillCombobox2();
        }
        void FillCombobox()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from itpm_project.add_session;";
            // string Query1 = "select * from addnotavailabletimeandroomdb.add_session;";
            //string Query2 = "select * from addnotavailabletimeandroomdb.student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn2);
            // MySqlCommand MyCommand4 = new MySqlCommand(Query2, MyConn2);

            MySqlDataReader reader;


            try
            {
                MyConn2.Open();
                reader = MyCommand2.ExecuteReader();



                while (reader.Read())
                {
                    String Name = reader.GetString("SubjectName");
                    concomboBox1.Items.Add(Name);


                }

            }
            catch (Exception e)
            {

            }
        }
        void FillCombobox1()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query4 = "select * from itpm_project.add_session;";


            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand4 = new MySqlCommand(Query4, MyConn2);


            MySqlDataReader reader3;


            try
            {
                MyConn2.Open();
                reader3 = MyCommand4.ExecuteReader();



                while (reader3.Read())
                {


                    string tag = reader3.GetString("tag");
                    concomboBox2.Items.Add(tag);



                }

            }
            catch (Exception e)
            {

            }
        }
        void FillCombobox2()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query3 = "select * from itpm_project.location;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn2);


            MySqlDataReader reader2;

            try
            {
                MyConn2.Open();
                reader2 = MyCommand3.ExecuteReader();



                while (reader2.Read())
                {
                    String textRoomName = reader2.GetString("textRoomName");
                    concomboBox3.Items.Add(textRoomName);


                }

            }
            catch (Exception e)
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";



                string Query = "insert into itpm_project.add_consecutive(session_1,session_2,selectroom) values('" + this.concomboBox1.Text + "','" + this.concomboBox2.Text + "','" + this.concomboBox3.Text + "');";
                // Query2 = "insert into addnotavailabletimeandroomdb.add_session(Session_ID) values('" + this.selectSessionComboBox.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Submit Data");
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

        private void button17_Click(object sender, EventArgs e)
        {
            concomboBox1.Text = string.Empty;
            concomboBox2.Text = string.Empty;
            concomboBox3.Text = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
                //Display query  
                string Query = "select * from  itpm_project.add_consecutive;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the workingDaysGridView object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
          
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

        private void WDWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
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

        }
    }
}

