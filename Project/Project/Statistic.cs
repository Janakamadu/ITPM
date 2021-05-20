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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void LocAADD_Click(object sender, EventArgs e)
        {
            string MyConnection2 = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            // string str = @"server=localhost;user id=root;persistsecurityinfo=True;database=addlocation";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand cmd, cmd1, cmd2;

            string query = "SELECT COUNT(ID) FROM add_lecturer";
            string query1 = "SELECT COUNT(idstudent) FROM student";
            string query2 = "SELECT COUNT(ID) FROM add_subject";

            try
            {
                MyConn2.Open();
                //label1.ForeColor = Color.black;
                // label1.Text = "Database Sucessfully Connected!!";

                cmd = new MySqlCommand(query, MyConn2);
                cmd1 = new MySqlCommand(query1, MyConn2);
                cmd2 = new MySqlCommand(query2, MyConn2);


                //debug code
                // var reader = cmd.ExecuteReader();

                //while (reader.Read())
                //{
                //Console.WriteLine(reader);

                // Do something with someValue
                //} 

                // read from db
                Int16 rows_count = Convert.ToInt16(cmd.ExecuteScalar());
                Int16 rows_count1 = Convert.ToInt16(cmd1.ExecuteScalar());
                Int16 rows_count2 = Convert.ToInt16(cmd2.ExecuteScalar());
                cmd.Dispose();
                cmd1.Dispose();
                cmd2.Dispose();
                MyConn2.Close();

                //Display data on the page
                label1.ForeColor = Color.Black;
                label1.Text = rows_count.ToString();

                label2.ForeColor = Color.Black;
                label2.Text = rows_count1.ToString();


                label3.ForeColor = Color.Black;
                label3.Text = rows_count2.ToString();



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (MyConn2.State == ConnectionState.Open)
                {
                    MyConn2.Close();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StacALecturer_Click(object sender, EventArgs e)
        {
            Add_Lecturer add = new Add_Lecturer();
            add.Show();
        }

        private void StacStudent_Click(object sender, EventArgs e)
        {
            Add_Student add = new Add_Student();
            add.Show();
        }

        private void StacSubject_Click(object sender, EventArgs e)
        {
            Add_Subject add = new Add_Subject();
            add.Show();
        }

        private void StacTag_Click(object sender, EventArgs e)
        {
            Add_Tag add = new Add_Tag();
            add.Show();
        }

        private void StacSession_Click(object sender, EventArgs e)
        {
            add_Session ass = new add_Session();
            ass.Show();
        }

        private void StacWorking_Click(object sender, EventArgs e)
        {
            WorkingDays_Hours wdh = new WorkingDays_Hours();
            wdh.Show();
        }

        private void StacRoom_Click(object sender, EventArgs e)
        {
            ManageSession2 manageSession2 = new ManageSession2();
            manageSession2.Show();
        }

        private void StacLocations_Click(object sender, EventArgs e)
        {
            Add_Location add = new Add_Location();
            add.Show();
        }

        private void StacTimeTable_Click(object sender, EventArgs e)
        {
            TTLecGenereate add = new TTLecGenereate();
            add.Show();
        }
    }
}
