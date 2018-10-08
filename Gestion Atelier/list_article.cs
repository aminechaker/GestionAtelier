using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Atelier
{
    public partial class list_article : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        public list_article()
        {
            InitializeComponent();
        }

        private void list_article_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionDataSet.article' table. You can move, or remove it, as needed.
            //this.articleTableAdapter.Fill(this.gestionDataSet.article);
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from article ";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualiser_Btn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from article ";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrieComboBox.Text == "Date")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from article ORDER BY DATE_DEBUT ";
                cmd.Connection = cnn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
            }
            if (TrieComboBox.Text == "Quantite")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from article ORDER BY Quantite";
                cmd.Connection = cnn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
            }
            if (TrieComboBox.Text == "Prix")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from article ORDER BY TOTAL";
                cmd.Connection = cnn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FinArticle_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand("UPDATE ARTICLE SET DATE_FIN = '" + DateTime.Now.ToShortDateString() + "' WHERE REFERENCE = '" + ReferenceTextBox.Text + "'", cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Operation avex Succée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool verifier()
        {
            if (ReferenceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Reference est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReferenceTextBox.Focus();
            }

            return true;
        }

        private void ReferenceTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from article where REFERENCE = '"+ ReferenceTextBox.Text +"' ";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }
    }
}
