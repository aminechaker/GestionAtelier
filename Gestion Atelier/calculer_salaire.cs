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
using Gestion_Atelier.Properties;

namespace Gestion_Atelier
{
    public partial class calculer_salaire : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        public calculer_salaire()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculer_salaire_Load(object sender, EventArgs e)
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
                IdComboBox.Items.Add(dr[2]);
            }
            dr.Close();
            cnn.Close();
        }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                SqlCommand cmd = new SqlCommand("SELECT NOM FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                SqlCommand cmd1 = new SqlCommand("SELECT PRENOM FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(HEURE_CUMULE) FROM POINTAGE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE = '" + AnneeTextBox.Text + "'", cnn);
                SqlCommand cmd3 = new SqlCommand("SELECT SALAIRE FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                cnn.Open();
                string nom = Convert.ToString(cmd.ExecuteScalar());
                string prenom = Convert.ToString(cmd1.ExecuteScalar());
                string nbr_heure = Convert.ToString(cmd2.ExecuteScalar());
                string prix_heure = Convert.ToString(cmd3.ExecuteScalar());
                NomLabel.Text = nom;
                PrenomLabel.Text = prenom;
                NbrHeureLabel.Text = nbr_heure;
                PrixHeureLabel.Text = prix_heure;
            }
            catch
            {
                
            }
        }

        private void Calculer_Btn_Click(object sender, EventArgs e)
        {
            if (verifier())
            {
                //try
                //{
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
                    SqlCommand cmd = new SqlCommand("SELECT NOM FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                    SqlCommand cmd1 = new SqlCommand("SELECT PRENOM FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                    SqlCommand cmd2 = new SqlCommand("SELECT SUM(HEURE_CUMULE) FROM POINTAGE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE = '" + AnneeTextBox.Text + "'", cnn);
                    SqlCommand cmd3 = new SqlCommand("SELECT SALAIRE FROM EMPLOYEES WHERE ID ='" + IdComboBox.Text + "'", cnn);
                    SqlCommand cmd4 = new SqlCommand("SELECT SUM(MONTANT_AVANCE) as somme FROM AVANCE WHERE ID ='" + IdComboBox.Text + "'", cnn);
                    cnn.Open();
                    string nom = Convert.ToString(cmd.ExecuteScalar());
                    string prenom = Convert.ToString(cmd1.ExecuteScalar());
                    double heure = Convert.ToDouble(cmd2.ExecuteScalar());
                    double prix = Convert.ToDouble(cmd3.ExecuteScalar());
                //double avance = Convert.ToDouble(cmd4.ExecuteScalar());
                DataTable dt = new DataTable();
                sda.SelectCommand = cmd4;
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string x = row["somme"].ToString();
                    //MessageBox.Show(x);
                    if (x == "")
                    {
                        double salaire_brut = heure * prix;
                        double salaire_net = salaire_brut ;
                        SqlCommand cmd5 = new SqlCommand("INSERT INTO SALAIRE(ID,NOM,PRENOM,MOIS,ANNEE,NOMBRE_HEURE,PRIX_HEURE,SALAIRE_BRUT,SALAIRE_NET) VALUES (@id,@nom,@prenom,'" + MoisComboBox.Text + "','" + AnneeTextBox.Text + "',@heure,@prix,@salaire_brut,@salaire_net)", cnn);
                        cmd5.Parameters.AddWithValue("@id", IdComboBox.Text);
                        cmd5.Parameters.AddWithValue("@nom", nom);
                        cmd5.Parameters.AddWithValue("@prenom", prenom);
                        cmd5.Parameters.AddWithValue("@heure", heure);
                        cmd5.Parameters.AddWithValue("@prix", prix);
                        cmd5.Parameters.AddWithValue("@salaire_brut", salaire_brut);
                        cmd5.Parameters.AddWithValue("@salaire_net", salaire_net);
                        cmd5.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Salaire calculé avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        //MessageBox.Show("Cet Employée n'a pas d'avance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        double avance = Convert.ToDouble(x);
                        double salaire_brut = heure * prix;
                        double salaire_net = salaire_brut - avance;
                        SqlCommand cmd5 = new SqlCommand("INSERT INTO SALAIRE(ID,NOM,PRENOM,MOIS,ANNEE,NOMBRE_HEURE,PRIX_HEURE,SALAIRE_BRUT,AVANCE,SALAIRE_NET) VALUES (@id,@nom,@prenom,'" + MoisComboBox.Text + "','" + AnneeTextBox.Text + "',@heure,@prix,@salaire_brut,@avance,@salaire_net)", cnn);
                        cmd5.Parameters.AddWithValue("@id", IdComboBox.Text);
                        cmd5.Parameters.AddWithValue("@nom", nom);
                        cmd5.Parameters.AddWithValue("@prenom", prenom);
                        cmd5.Parameters.AddWithValue("@heure", heure);
                        cmd5.Parameters.AddWithValue("@prix", prix);
                        cmd5.Parameters.AddWithValue("@avance", avance);
                        cmd5.Parameters.AddWithValue("@salaire_brut", salaire_brut);
                        cmd5.Parameters.AddWithValue("@salaire_net", salaire_net);
                        cmd5.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Salaire calculé avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            //}
            //    catch
            //{
            //    MessageBox.Show("Salaire déjà calculé", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
        }
}

        private bool verifier()
        {
            if (MoisComboBox.Text == string.Empty)
            {
                MessageBox.Show("Veuillez choisir un Mois", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MoisComboBox.Focus();
            }
            if (IdComboBox.Text == string.Empty)
            {
                MessageBox.Show("Identifiant est Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdComboBox.Focus();
            }
            if (AnneeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Veuillez entrer une Année", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AnneeTextBox.Focus();
            }
            else
            {
                int tempAnnee;
                bool isNumeric = int.TryParse(AnneeTextBox.Text.Trim(), out tempAnnee);

                if (!isNumeric)
                {
                    MessageBox.Show("L'Année doit être une valeur Numerique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AnneeTextBox.Clear();
                    AnneeTextBox.Focus();
                    return false;
                }
            }


            return true;
        }

        private void FichedePaie_Btn_Click(object sender, EventArgs e)
        {
            if (IdComboBox.Text == string.Empty)
            {
                MessageBox.Show("Identifiant est Obligatoire", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdComboBox.Focus();
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            Image image = Resources.rectangle;
            e.Graphics.DrawImage(image, 25, 195 , image.Width, image.Height);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from salaire where ID = '" + IdComboBox.Text + "'";
            SqlCommand cmd1 = new SqlCommand("SELECT SALAIRE_BRUT FROM SALAIRE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE ='" + AnneeTextBox.Text + "'", cnn);
            SqlCommand cmd2 = new SqlCommand("SELECT AVANCE FROM SALAIRE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '"+ MoisComboBox.Text +"' AND ANNEE ='"+ AnneeTextBox.Text+"'", cnn);
            SqlCommand cmd3 = new SqlCommand("SELECT SALAIRE_NET FROM SALAIRE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE ='" + AnneeTextBox.Text + "'", cnn);
            SqlCommand cmd4 = new SqlCommand("SELECT NOMBRE_HEURE FROM SALAIRE WHERE ID ='" + IdComboBox.Text + "' AND MOIS = '" + MoisComboBox.Text + "' AND ANNEE ='" + AnneeTextBox.Text + "'", cnn);
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataTable dt1 = new DataTable();
            sda.SelectCommand = cmd2;
            sda.Fill(dt1);
            cnn.Open();
            foreach (DataRow row1 in dt1.Rows)
            {
                string x = row1["avance"].ToString();
                if (x == "")
                {
                    Double salaireb = Convert.ToDouble(cmd1.ExecuteScalar());
                    //Double avance = Convert.ToDouble(cmd2.ExecuteScalar());
                    Double salairen = Convert.ToDouble(cmd3.ExecuteScalar());
                    Double heure = Convert.ToDouble(cmd4.ExecuteScalar());
                    foreach (DataRow row in dt.Rows)
                    {
                        string id = row["ID"].ToString();
                        string nom = row["NOM"].ToString();
                        string prenom = row["PRENOM"].ToString();
                        string mois = row["MOIS"].ToString();
                        string annee = row["ANNEE"].ToString();
                        string prix = row["PRIX_HEURE"].ToString();

                        e.Graphics.DrawString("BULLETIN DE PAIE", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(40, 40));
                        e.Graphics.DrawString("Date:   " + DateTime.Now.ToShortDateString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(540, 25));
                        e.Graphics.DrawString("Nom : " + nom + prenom, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 210));
                        e.Graphics.DrawString("Mois : " + MoisComboBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 285));
                        e.Graphics.DrawString("Année : " + AnneeTextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 360));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 400));
                        e.Graphics.DrawString("Nombre des Heures", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 425));
                        e.Graphics.DrawString("Prix Heure", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 425));
                        e.Graphics.DrawString("Salaire Brut", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(520, 425));
                        e.Graphics.DrawString("Avance", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(700, 425));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 450));
                        e.Graphics.DrawString(heure.ToString(".###"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 475));
                        e.Graphics.DrawString(prix, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(315, 475));
                        e.Graphics.DrawString(salaireb.ToString(".###"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(535, 475));
                        e.Graphics.DrawString("0 DT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(710, 475));
                    }
                    e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 500));
                    e.Graphics.DrawString("Salaire NET : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, 525));
                    e.Graphics.DrawString(salairen.ToString(".###") + " " + "DT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(620, 525));
                    e.Graphics.DrawString("All right reserved AMINE CHAKER© 2017", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(530, 1150));

                }
                else
                {
                    Double salaireb = Convert.ToDouble(cmd1.ExecuteScalar());
                    Double avance = Convert.ToDouble(cmd2.ExecuteScalar());
                    Double salairen = Convert.ToDouble(cmd3.ExecuteScalar());
                    Double heure = Convert.ToDouble(cmd4.ExecuteScalar());
                    foreach (DataRow row in dt.Rows)
                    {
                        string id = row["ID"].ToString();
                        string nom = row["NOM"].ToString();
                        string prenom = row["PRENOM"].ToString();
                        string mois = row["MOIS"].ToString();
                        string annee = row["ANNEE"].ToString();
                        string prix = row["PRIX_HEURE"].ToString();

                        e.Graphics.DrawString("BULLETIN DE PAIE", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(40, 40));
                        e.Graphics.DrawString("Date:   " + DateTime.Now.ToShortDateString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(540, 25));
                        e.Graphics.DrawString("Nom : " + nom + prenom, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 210));
                        e.Graphics.DrawString("Mois : " + MoisComboBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 285));
                        e.Graphics.DrawString("Année : " + AnneeTextBox.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(32, 360));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 400));
                        e.Graphics.DrawString("Nombre des Heures", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 425));
                        e.Graphics.DrawString("Prix Heure", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(300, 425));
                        e.Graphics.DrawString("Salaire Brut", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(520, 425));
                        e.Graphics.DrawString("Avance", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(700, 425));
                        e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 450));
                        e.Graphics.DrawString(heure.ToString(".###"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(30, 475));
                        e.Graphics.DrawString(prix, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(315, 475));
                        e.Graphics.DrawString(salaireb.ToString(".###"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(535, 475));
                        e.Graphics.DrawString(avance.ToString(".###"), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(710, 475));
                    }
                    e.Graphics.DrawString("------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 500));
                    e.Graphics.DrawString("Salaire NET : ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(500, 525));
                    e.Graphics.DrawString(salairen.ToString(".###") + " " + "DT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(620, 525));
                    e.Graphics.DrawString("All right reserved AMINE CHAKER© 2017", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(530, 1150));

                }
            }
            
        }
    }
}
