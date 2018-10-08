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
    public partial class ajouter_employe : Form
    {
        public ajouter_employe()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ajouter_employe_btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into employees (NOM,PRENOM,CONTACT,FONCTION,SALAIRE) values ('" + NomTextBox.Text + "','" + PrenomTextBox.Text + "','" + ContactTextBox.Text + "','" + FonctionComboBox.Text + "','" + SalaireTextBox.Text + "')";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employe ajouté avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'employé", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            NomTextBox.Clear();
            PrenomTextBox.Clear();
            ContactTextBox.Clear();
            SalaireTextBox.Clear();
        }

        private bool verifier()
        {
            if (NomTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nom est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NomTextBox.Focus();
            }
            if (PrenomTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prenom est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrenomTextBox.Focus();
            }
            if (ContactTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Contact est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTextBox.Focus();
            }
            else
            {
                int tempContact;
                bool isNumeric = int.TryParse(ContactTextBox.Text.Trim(), out tempContact);

                if (!isNumeric)
                {
                    MessageBox.Show("Le Numéro de Telephone doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ContactTextBox.Clear();
                    ContactTextBox.Focus();
                    return false;
                }
            }
            if (ContactTextBox.Text.Length != 8 )
            {
                MessageBox.Show("Veuillez vérifier le numero de telephone", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactTextBox.Focus();
            }
            if (FonctionComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Fonction est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FonctionComboBox.Focus();
            }
            if (SalaireTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Salaire est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SalaireTextBox.Focus();
            }

            return true;
        }

        private void ajouter_employe_Load(object sender, EventArgs e)
        {
            LoadAllFonctions();
        }

        private void LoadAllFonctions()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand("GET_FONCTIONS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                FonctionComboBox.Items.Add(dr[1]);
            }
            dr.Close();
            cnn.Close();
        }
    }
}
