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
    public partial class Edit_Location : Form
    {
        public Edit_Location()
        {
            InitializeComponent();
        }

        private void comboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query = "SELECT * from location where locationID='" + comboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader;

            try
            {
                conn.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    String buildingNameComboBox = dReader.GetString("buildingNameComboBox");
                    String textRoomName = dReader.GetString("textRoomName");
                    String capacityComboBox = dReader.GetString("capacityComboBox");
                    String roomType = dReader.GetString("roomType");
                
                    LocEcomboBox1.Text = buildingNameComboBox;
                    LocEtextBox1.Text = textRoomName;
                    LocEcomboBox2.Text = capacityComboBox;
                    LocEcomboBox3.Text = roomType;
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void LUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE location SET buildingNameComboBox='" + LocEcomboBox1.Text + "',textRoomName='" + LocEtextBox1.Text + "',capacityComboBox='" + LocEcomboBox2.Text + "',roomType='" + LocEcomboBox3.Text + "'where locationID ='" + comboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Location record Update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the Location record" + ex);

            }
        }

        private void LEDELETE_Click(object sender, EventArgs e)
        {
            View_Location view_Location = new View_Location();
            view_Location.Show();

        }
    }
}
