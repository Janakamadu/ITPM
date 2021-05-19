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
    public partial class ManageSessionRoom : Form
    {
        public ManageSessionRoom()
        {
            InitializeComponent();
            FillCombobox();
            FillCombobox1();
        }
        void FillCombobox()
        {
            string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string Query1 = "select * from add_session;";


            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn2);


            MySqlDataReader reader;


            try
            {
                MyConn2.Open();
                reader = MyCommand3.ExecuteReader();



                while (reader.Read())
                {
                    String SessionID = reader.GetString("Session_ID");
                    // String Lname = reader.GetString("LName");
                    MScomboBox1.Items.Add(SessionID);
                    // SelectSession1.Items.Add(Lname);


                }

            }
            catch (Exception e)
            {

            }
        }
        void FillCombobox1()
        {
            string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string Query1 = "select * from location;";


            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand3 = new MySqlCommand(Query1, MyConn2);


            MySqlDataReader reader;


            try
            {
                MyConn2.Open();
                reader = MyCommand3.ExecuteReader();



                while (reader.Read())
                {
                    String rname = reader.GetString("textRoomName");
                    // String Lname = reader.GetString("LName");
                    MScomboBox2.Items.Add(rname);
                    //SelectSession1.Items.Add(Lname);


                }

            }
            catch (Exception e)
            {

            }
        }

        private void MScomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string mainconn = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            //string mainconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            MySqlConnection sqlc = new MySqlConnection(mainconn);
            String Query = "select * from add_session where Session_ID= '" + this.MScomboBox1.Text + "'";
            MySqlCommand sqlcom = new MySqlCommand(Query, sqlc);
            sqlc.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            MSdataGridView1.DataSource = dt;
            sqlc.Close();
        }

        private void MScomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mainconn = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            //string mainconn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            MySqlConnection sqlc = new MySqlConnection(mainconn);
            String Query = "select * from location where textRoomName= '" + this.MScomboBox2.Text + "'";
            MySqlCommand sqlcom = new MySqlCommand(Query, sqlc);
            sqlc.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            MSdataGridView2.DataSource = dt;
            sqlc.Close();
        }

        private void LocAADD_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";



                string Query = "insert into session_room(Session_ID,room_name) values('" + this.MScomboBox1.Text + "','" + this.MScomboBox2.Text + "');";
                // Query2 = "insert into add_session(Session_ID) values('" + this.selectSessionComboBox.Text + "');";
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
    }
}
