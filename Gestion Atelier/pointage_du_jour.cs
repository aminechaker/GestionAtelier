using Gestion_Atelier.Properties;
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
    public partial class pointage_du_jour : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();


        public pointage_du_jour()
        {
            InitializeComponent();
        }

        private void EntrerPictureBox_MouseHover(object sender, EventArgs e)
        {
            EntrerPictureBox.Image = Resources.entrer1;
        }

        private void EntrerPictureBox_MouseLeave(object sender, EventArgs e)
        {
            EntrerPictureBox.Image = Resources.entrer;
        }

        private void SortiePictureBox_MouseHover(object sender, EventArgs e)
        {
            SortiePictureBox.Image = Resources.sortie1;
        }

        private void SortiePictureBox_MouseLeave(object sender, EventArgs e)
        {
            SortiePictureBox.Image = Resources.sortie;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EntrerPictureBox_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    string date = dateTimePicker1.Value.ToShortDateString();
                    string a = DateTime.Now.ToShortTimeString();
                    DateTime time = Convert.ToDateTime(a);
                    DateTime pause = Convert.ToDateTime("00:30");
                    cmd.CommandText = "insert into pointage (ID,DATE_POINTAGE,MOIS,ANNEE,HEURE_ENTRE,PAUSE) values ('" + IdTextBox.Text + "','" + date + "','" + dateTimePicker1.Value.Month + "','" + dateTimePicker1.Value.Year + "','" + time + "','" + pause + "')";
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pointage ajouté avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors de l'ajout du Pointage", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private bool verifier()
        {
            if (IdTextBox.Text == string.Empty)
            {
                MessageBox.Show("Identifiant est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdTextBox.Focus();
            }
            else
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
            }
            return true;
        }

        private void SortiePictureBox_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                try
                {
                    string a = DateTime.Now.ToShortTimeString();
                    DateTime time = Convert.ToDateTime(a);
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = " update pointage set HEURE_SORTIE ='" + time + "' where ID = '" + IdTextBox.Text + "'and DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'";
                    cmd.Connection = cnn;
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("SELECT DATEDIFF(MINUTE,HEURE_ENTRE,HEURE_SORTIE) FROM POINTAGE WHERE ID = '" + IdTextBox.Text + "' AND DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    cmd2.Connection = cnn;
                    float minute = Convert.ToInt32(cmd2.ExecuteScalar()) - 30;
                    double cumule = (minute / 60);
                    SqlCommand cmd3 = new SqlCommand("update pointage set HEURE_CUMULE ='" + cumule + "' where ID = '" + IdTextBox.Text + "' and DATE_POINTAGE = '" + dateTimePicker1.Value.ToShortDateString() + "'", cnn);
                    cmd3.Connection = cnn;
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Pointage modifier avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("Erreur lors du modification du Pointage", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if( IdTextBox.Text == string.Empty)
            {
                IdTextBox.Focus();
            }
            else if ( numeric() )
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
