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
    public partial class supprimer_employe : Form
    {
        public supprimer_employe()
        {
            InitializeComponent();
        }

        private void Supprimer_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from employees where ID='" + IdTextBox.Text + "'";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employée Retiré avec succes", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du retrait de l'employée", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private bool verifier()
        {
            if (IdTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Identifiant est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdTextBox.Focus();
            }
            return true;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isnumeric())
            {
                if (IdTextBox.Text.Trim() == string.Empty)
                {
                    IdTextBox.Focus();
                }
                else
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand("SELECT NOM FROM EMPLOYEES WHERE ID = '" + IdTextBox.Text + "'", cnn);
                    SqlCommand cmd1 = new SqlCommand("SELECT PRENOM FROM EMPLOYEES WHERE ID = '" + IdTextBox.Text + "'", cnn);
                    cnn.Open();
                    string nom = Convert.ToString(cmd.ExecuteScalar());
                    string prenom = Convert.ToString(cmd1.ExecuteScalar());
                    NomLabel.Text = prenom + nom;
                    NomLabel.ForeColor = Color.Red;
                    cnn.Close();
                }       
            }
        }

        private bool isnumeric()
        {
            if (IdTextBox.Text.Trim() == string.Empty)
            {
                IdTextBox.Focus();
            }
            else
            {
                int tempContact;
                bool isNumeric = int.TryParse(IdTextBox.Text.Trim(), out tempContact);

                if (!isNumeric)
                {
                    MessageBox.Show("L'identifiant doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdTextBox.Clear();
                    IdTextBox.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
