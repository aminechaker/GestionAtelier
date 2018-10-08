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
    public partial class ajouter_avance : Form
    {
        public ajouter_avance()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into avance (ID,DATE_AVANCE,MONTANT_AVANCE) values ('" + IdComboBox.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + MontantTextBox.Text + "')";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Avance ajouté avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'Avance", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            MontantTextBox.Clear();
            IdComboBox.Text = string.Empty;
        }

        private bool verifier()
        {
            if (IdComboBox.Text == string.Empty)
            {
                MessageBox.Show("Identifiant est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdComboBox.Focus();
            }
            if (MontantTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez entrer un Montant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MontantTextBox.Focus();
            }

            return true;
        }

        private void ajouter_avance_Load(object sender, EventArgs e)
        {
            LoadAllIdentifiers();
        }

        private void LoadAllIdentifiers()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand("GET_IDETIFIANT", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IdComboBox.Items.Add(dr[0]);
            }
            dr.Close();
            cnn.Close();
        }
    }
}
