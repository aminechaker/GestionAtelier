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
using DGVPrinterHelper;

namespace Gestion_Atelier
{
    public partial class list_pointage : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataReader dr;
        SqlDataAdapter sda = new SqlDataAdapter();
        public list_pointage()
        {
            InitializeComponent();
        }

        private void list_pointage_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEntities.pointage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.pointageTableAdapter2.Fill(this.gestionEntities.pointage);
            // TODO: cette ligne de code charge les données dans la table 'gestionDataSet1.pointage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.pointageTableAdapter1.Fill(this.gestionDataSet1.pointage);
            using (gestionEntities db = new gestionEntities())
            {
                pointageBindingSource.DataSource = db.pointage.ToList();
            }

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from pointage ";
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
            cmd.CommandText = "select * from pointage ";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }

        private void TrieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrieComboBox.Text == "Identifiant")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from pointage ORDER BY ID,DATE_POINTAGE ";
                cmd.Connection = cnn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
            }
            if (TrieComboBox.Text == "Date")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from pointage ORDER BY DATE_POINTAGE";
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

        private void Rechercher_Btn_Click(object sender, EventArgs e)
        {
            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from pointage where ID = '"+ IdTextBox.Text +"'";
            //cmd.Connection = cnn;
            //sda.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //BindingSource bSource = new BindingSource();
            //bSource.DataSource = dt;
            //dataGridView1.DataSource = bSource;
            //sda.Update(dt);
        }

        private void Imprimer_Btn_Click(object sender, EventArgs e)
        {
            imprimer_pointage frm = new imprimer_pointage();
            frm.ShowDialog();
        }
    }
}
