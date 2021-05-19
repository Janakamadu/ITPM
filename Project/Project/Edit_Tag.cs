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
    public partial class Edit_Tag : Form
    {
        public Edit_Tag()
        {
            InitializeComponent();
        }

        private void TagEcomboBoxRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string query = "SELECT * from tag where idtag='" + TagEcomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dReader;

            try
            {
                conn.Open();
                dReader = cmd.ExecuteReader();
                while (dReader.Read())
                {
                    String tag_name = dReader.GetString("tag_name");
                    String tag_code = dReader.GetString("tag_code");
                    String related_tag = dReader.GetString("related_tag");
               
                    TagEtextBox1.Text = tag_name;
                    TagEtextBox2.Text = tag_code;
                    TagEcomboBox1.Text = related_tag;
            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Reterive the value dye to" + ex);
            }
        }

        private void TagUPDATE_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=itpm_project;password=root";
            string updateQuery = "UPDATE tag SET tag_name='" + TagEtextBox1.Text + "',tag_code='" + TagEtextBox2.Text + "',related_tag='" + TagEcomboBox1.Text +"'where idtag ='" + TagEcomboBoxRollNo.Text + "'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
            MySqlDataReader mReader;

            try
            {
                conn.Open();
                mReader = cmd.ExecuteReader();
                MessageBox.Show("Tag record Update successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the Tag record" + ex);

            }
        }

        private void TagBack_Click(object sender, EventArgs e)
        {
            View_Tag view_Tag = new View_Tag();
            view_Tag.Show();
        }
    }
}
