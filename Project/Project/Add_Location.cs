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
    }
}
