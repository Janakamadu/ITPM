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
    }
}
