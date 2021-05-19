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
    public partial class ViewWorkingDays : Form
    {
        public ViewWorkingDays()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM addworkintable ";
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
                WDdataGridView1.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }

        private void WDEDIT_Click(object sender, EventArgs e)
        {
            EditWorkingDays editWorkingDays = new EditWorkingDays();
            editWorkingDays.Show();
        }

        private void WDDELETE_Click(object sender, EventArgs e)
        {
            DeleteWorkingDayscs deleteWorkingDayscs = new DeleteWorkingDayscs();
            deleteWorkingDayscs.Show();
        }
    }
}
