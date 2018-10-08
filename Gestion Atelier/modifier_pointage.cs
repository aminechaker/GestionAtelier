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
    public partial class modifier_pointage : Form
    {
        public modifier_pointage()
        {
            InitializeComponent();
        }

        private void Confirmer_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd1 = new SqlCommand("SELECT DATEDIFF(MINUTE,'00:00:00',PAUSE) FROM POINTAGE WHERE ID = '" + IdTextBox.Text + "' AND DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    SqlCommand cmd3 = new SqlCommand("SELECT DATEDIFF(MINUTE,'00:00:00',HEURE_ENTRE) FROM POINTAGE WHERE ID = '" + IdTextBox.Text + "' AND DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    SqlCommand cmd4 = new SqlCommand("SELECT DATEDIFF(MINUTE,'00:00:00',HEURE_SORTIE) FROM POINTAGE WHERE ID = '" + IdTextBox.Text + "' AND DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update pointage set PAUSE = '" + PauseTextBox.Text + "' where ID = '" + IdTextBox.Text + "' and DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "' ";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    double cumule = (Convert.ToDouble(cmd4.ExecuteScalar()) / 60) - (Convert.ToDouble(cmd3.ExecuteScalar()) / 60) - (Convert.ToDouble(cmd1.ExecuteScalar()) / 60);
                    SqlCommand cmd2 = new SqlCommand("update pointage set HEURE_CUMULE ='" + cumule + "' where ID = '" + IdTextBox.Text + "' and DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    cmd2.Connection = cnn;
                    cmd2.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Pointage modifié avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erreur lors du modification du Pointage", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }
        }

        private bool verifier()
        {
            if (IdTextBox.Text == string.Empty)
            {
                MessageBox.Show("Veuillez entrer un Idenfifiant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdTextBox.Focus();
            }
            if (PauseTextBox.Text == string.Empty)
            {
                MessageBox.Show("Durée de pause est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PauseTextBox.Focus();
            }

            return true;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IdTextBox.Text == string.Empty)
            {
                IdTextBox.Focus();
            }
            else if (numeric())
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand("select nom from employees where id = '" + IdTextBox.Text + "'", cnn);
                SqlCommand cmd1 = new SqlCommand("select prenom from employees where id = '" + IdTextBox.Text + "'", cnn);
                cnn.Open();
                string nom = Convert.ToString(cmd.ExecuteScalar());
                string prenom = Convert.ToString(cmd1.ExecuteScalar());
                NomLabel.Text = prenom + nom;
                NomLabel.ForeColor = Color.Red;
            }
        }

        private bool numeric()
        {
            int tempId;
            bool isNumeric = int.TryParse(IdTextBox.Text.Trim(), out tempId);

            if (!isNumeric)
            {
                MessageBox.Show("L'identifiant doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdTextBox.Clear();
                IdTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
