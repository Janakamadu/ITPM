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
    public partial class View_Tag : Form
    {
        public View_Tag()
        {
            InitializeComponent();
            displayData();
        }

        public void displayData()
        {

            string conString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string displayQuery = " SELECT * FROM tag";
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
                dataGridViewTag.DataSource = bSource;
                myAdapter.Update(stTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to the Reterive the lecturer's record" + ex);
            }
        }
        private void dataGridViewTag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TagEDIT_Click(object sender, EventArgs e)
        {
            Edit_Tag edit_Tag = new Edit_Tag();
            edit_Tag.Show();
        }

        private void TagDELETE_Click(object sender, EventArgs e)
        {
            Delete_Tag delete_Tag = new Delete_Tag();
            delete_Tag.Show();
        }
    }
}
