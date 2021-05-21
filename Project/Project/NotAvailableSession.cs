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
    public partial class NotAvailableSession : Form
    {
        public NotAvailableSession()
        {
            InitializeComponent();
            FillCombobox();
            FillCombobox1();
            FillCombobox2();
            FillCombobox3();
        }
        void FillCombobox()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query = "select * from itpm_project.add_lecturer;";
            string Query1 = "select * from itpm_project.add_session;";
            string Query2 = "select * from itpm_project.student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn2);
            MySqlCommand MyCommand4 = new MySqlCommand(Query2, MyConn2);

            MySqlDataReader reader;


            try
            {
                MyConn2.Open();
                reader = MyCommand2.ExecuteReader();



                while (reader.Read())
                {
                    String Name = reader.GetString("LName");
                    selectLecturerComboBox.Items.Add(Name);


                }

            }
            catch (Exception e)
            {

            }
        }

        void FillCombobox1()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query2 = "select * from itpm_project.student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query2, MyConn2);


            MySqlDataReader reader1;

            try
            {
                MyConn2.Open();
                reader1 = MyCommand2.ExecuteReader();



                while (reader1.Read())
                {
                    String groupno = reader1.GetString("grp_no");
                    selectGroupComboBox.Items.Add(groupno);


                }

            }
            catch (Exception e)
            {

            }
        }
        void FillCombobox2()
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            string Query3 = "select * from itpm_project.student;";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(Query3, MyConn2);


            MySqlDataReader reader2;

            try
            {
                MyConn2.Open();
                reader2 = MyCommand3.ExecuteReader();



                while (reader2.Read())
                {
                    String subgroupno = reader2.GetString("sub_grp_no");
                    selectSubGroupComboBox.Items.Add(subgroupno);


                }

            }
            catch (Exception e)
            {

            }
        }

        void FillCombobox3()
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


                    string sessionid = reader3.GetString("Session_ID");
                    selectSessionComboBox.Items.Add(sessionid);



                }

            }
            catch (Exception e)
            {

            }
        }

        private void NATRVAdvanced_Click(object sender, EventArgs e)
        {
            Consecutive_Session consecutive_Session = new Consecutive_Session();
            consecutive_Session.Show();
        }

        private void btnSaveNotTime_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";



                string Query = "insert into itpm_project.addsessionnot(LName,grp_no,sub_grp_no,Session_ID,Time) values('" + this.selectLecturerComboBox.Text + "','" + this.selectGroupComboBox.Text + "','" + this.selectSubGroupComboBox.Text + "','" + this.selectSessionComboBox.Text + "','" + this.textTime.Text + "');";
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

        private void btnViewNotTime_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
                //Display query  
                string Query = "select * from itpm_project.addsessionnot;";
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

        private void btnClearNotTime_Click(object sender, EventArgs e)
        {
            selectLecturerComboBox.Text = string.Empty;
            selectGroupComboBox.Text = string.Empty;
            selectSubGroupComboBox.Text = string.Empty;
            selectSessionComboBox.Text = string.Empty;
            textTime.Text = string.Empty;
        }

        private void btndeleteNot_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletenotTime_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
            }


        }

        private void NATRVLecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void NATRVStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void NATRVSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void NATRVTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void NATRVSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void NATRVRoom_Click(object sender, EventArgs e)
        {
            ManageSessionRoom mng = new ManageSessionRoom();
            mng.Show();
        }

        private void NATRVLocations_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }

        private void NATRVStatistics_Click(object sender, EventArgs e)
        {
            Statistic statistic = new Statistic();
            statistic.Show();
        }

        private void NATRVTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }

        private void NATRVWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
        }

        private void NATRVHome_Click(object sender, EventArgs e)
        {

            Homepage homepage = new Homepage();
            homepage.Show();
        }
    }
}
