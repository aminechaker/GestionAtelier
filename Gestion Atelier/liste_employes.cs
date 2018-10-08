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
    public partial class liste_employes : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataReader dr;
        SqlDataAdapter sda = new SqlDataAdapter();
        public liste_employes()
        {
            InitializeComponent();
        }

        private void liste_employes_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employees order by ID";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
            PrenomTextBox.Text = "";
        }

        private void Actualiser_Btn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employees order by ID";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
            PrenomTextBox.Text = "";
        }

        private void Rechercher_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from employees where (PRENOM ='" + PrenomTextBox.Text + "')";
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

        private bool verifier()
        {
            if (PrenomTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez entrer un Prenom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrenomTextBox.Focus();
            }

            return true;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
