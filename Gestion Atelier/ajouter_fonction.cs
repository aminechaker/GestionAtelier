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
    public partial class ajouter_fonction : Form
    {
        public ajouter_fonction()
        {
            InitializeComponent();
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
                    cmd.CommandText = "insert into fonctions (DESCRIPTION) values ('" + DescriptionTextBox.Text + "')";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fonction ajouté avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout de la fonction", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private bool verifier()
        {
            if (DescriptionTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Description de la fonction est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescriptionTextBox.Focus();
            }
            return true;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
