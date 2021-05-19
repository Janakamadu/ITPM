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
    public partial class Add_Tag : Form
    {
        public Add_Tag()
        {
            InitializeComponent();
        }

        private void TagADD_Click(object sender, EventArgs e)
        {

            string connection = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string insertDataQuery = "INSERT INTO tag(tag_name,tag_code,related_tag) values('" + this.TagtextBox1.Text + "','" + this.TagtextBox2.Text + "','" + this.TagcomboBox1.Text + "')";
            MySqlConnection con = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(insertDataQuery, con);
            MySqlDataReader dataReader;

            try
            {
                con.Open();
                dataReader = cmd.ExecuteReader();
                MessageBox.Show("Add the Tag details succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unabe the Data insert due to " + ex);

            }
        }

        private void TagCLEAR_Click(object sender, EventArgs e)
        {
            TagtextBox1.Clear();
            TagtextBox2.Clear();
            TagcomboBox1.Text = string.Empty;

        }

        private void TagLabel3_Click(object sender, EventArgs e)
        {
            View_Tag view_Tag = new View_Tag();
            view_Tag.Show();
        }
    }
}
