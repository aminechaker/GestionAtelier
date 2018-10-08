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
    public partial class ajouter_article : Form
    {
        public ajouter_article()
        {
            InitializeComponent();
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
                    cmd.CommandText = "insert into article (REFERENCE,QUANTITE,PRIX_UNITAIRE,DATE_DEBUT,TOTAL) values (@reference,@quantite,@prix,@date,@total)";
                    cmd.Connection = cnn;
                    cnn.Open();
                    Double total = Convert.ToDouble(QuantiteTextBox.Text) * Convert.ToDouble(PrixTextBox.Text);
                    cmd.Parameters.AddWithValue("@reference", ReferenceTextBox.Text);
                    cmd.Parameters.AddWithValue("@quantite", Convert.ToDouble(QuantiteTextBox.Text));
                    cmd.Parameters.AddWithValue("@prix", Convert.ToDouble(PrixTextBox.Text));
                    cmd.Parameters.AddWithValue("@date", dateTimePicker2.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Article ajouté avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'Article", "Erreur", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            ReferenceTextBox.Clear();
            QuantiteTextBox.Clear();
            PrixTextBox.Clear();
        }

        private bool verifier()
        {
            if (ReferenceTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Reference est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReferenceTextBox.Focus();
            }
            if (QuantiteTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Quantite est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                QuantiteTextBox.Focus();
            }
            else
            {
                int tempQuantite;
                bool isNumeric = int.TryParse(QuantiteTextBox.Text.Trim(), out tempQuantite);

                if (!isNumeric)
                {
                    MessageBox.Show("La Quantite doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QuantiteTextBox.Clear();
                    QuantiteTextBox.Focus();
                    return false;
                }
            }
            if (PrixTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Prix Unitaire est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PrixTextBox.Focus();
            }
            else
            {
                int tempPrix;
                bool isNumeric = int.TryParse(QuantiteTextBox.Text.Trim(), out tempPrix);

                if (!isNumeric)
                {
                    MessageBox.Show("Le Prix Unitaire doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PrixTextBox.Clear();
                    PrixTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
