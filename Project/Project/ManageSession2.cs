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
    public partial class ManageSession2 : Form
    {
        public ManageSession2()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM session_room";
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd = new MySqlCommand(displayQuery, con);
            MySqlDataAdapter myAdapter = new MySqlDataAdapter();

            try
            {
                myAdapter.SelectCommand = cmd;
                DataTable stTable = new DataTable();
                myAdapter.Fill(stTable);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = stTable;
                MS2dataGridView1.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }

        private void ManageSession2_Load(object sender, EventArgs e)
        {
           
        }

        private void MS2ADD_Click(object sender, EventArgs e)
        {
           ManageSessionRoom manageSessionRoom = new ManageSessionRoom();
           manageSessionRoom.Show();
        }

        private void MS3Label3_Click(object sender, EventArgs e)
        {
            NotARoom notARoom = new NotARoom();
            notARoom.Show();
        }
    }
}
