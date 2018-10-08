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
    public partial class imprimer_pointage : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataReader dr;
        SqlDataAdapter sda = new SqlDataAdapter();
        public imprimer_pointage()
        {
            InitializeComponent();
        }

        private void imprimer_pointage_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionEntities.pointage'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.pointageTableAdapter.Fill(this.gestionEntities.pointage);
            using (gestionEntities db = new gestionEntities())
            {
                pointageBindingSource.DataSource = db.pointage.ToList();
            }
            AnneeTextBox.Text = DateTime.Now.Year.ToString();
        }

        private void Rechercher_Btn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID,DATE_POINTAGE,HEURE_ENTRE,HEURE_SORTIE,PAUSE,HEURE_CUMULE from pointage where ID = '" + IdTextBox.Text + "'";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }

        private void Imprimer_Btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Presence du Mois" + DateTime.Now.Month;
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToShortDateString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "Amine Chaker";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IdTextBox.Text.Trim() == string.Empty)
            {
                IdTextBox.Focus();
            }
            else
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID,DATE_POINTAGE,HEURE_ENTRE,HEURE_SORTIE,PAUSE,HEURE_CUMULE from pointage where ID = '" + IdTextBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE = '" + AnneeTextBox.Text + "'";
                cmd.Connection = cnn;
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);
                SqlCommand cmd1 = new SqlCommand("select prenom from pointage where id = '" + IdTextBox.Text + "'", cnn);
                cnn.Open();
                string prenom = Convert.ToString(cmd1.ExecuteScalar());
                NomLabel.Text = prenom;
                NomLabel.ForeColor = Color.Red;
            }
            
        }
    }
}
