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
    public partial class View_Session : Form
    {
        public View_Session()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM add_session";
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
                dataGridViewSession.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the Session's record" + ex);
            }
        }

        private void SesEDIT_Click(object sender, EventArgs e)
        {
            Edit_Session edit_Session = new Edit_Session();
            edit_Session.Show();
        }

        private void SesDELETE_Click(object sender, EventArgs e)
        {
            Delete_Session delete_Session = new Delete_Session();
            delete_Session.Show();

        }
    }
}
