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

namespace Gestion_Atelier
{
    public partial class employes : Form
    {
        public employes()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterEmployePictureBox_MouseHover(object sender, EventArgs e)
        {
            AjouterEmployePictureBox.Image = Resources.ajouter_employe1;
        }

        private void AjouterEmployePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AjouterEmployePictureBox.Image = Resources.ajouter_employe;
        }

        private void ListeDesEmployesPictureBox_MouseHover(object sender, EventArgs e)
        {
            ListeDesEmployesPictureBox.Image = Resources.liste_employe1;
        }

        private void ListeDesEmployesPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListeDesEmployesPictureBox.Image = Resources.liste_employe;
        }

        private void SupprimerEmployesPictureBox_MouseHover(object sender, EventArgs e)
        {
            SupprimerEmployesPictureBox.Image = Resources.supprimer_employe1;
        }

        private void SupprimerEmployesPictureBox_MouseLeave(object sender, EventArgs e)
        {
            SupprimerEmployesPictureBox.Image = Resources.supprimer_employe;
        }

        private void AjouterEmployePictureBox_Click(object sender, EventArgs e)
        {
            ajouter_employe frm = new ajouter_employe();
            frm.ShowDialog();
        }

        private void ListeDesEmployesPictureBox_Click(object sender, EventArgs e)
        {
            liste_employes frm = new liste_employes();
            frm.ShowDialog();
        }

        private void SupprimerEmployesPictureBox_Click(object sender, EventArgs e)
        {
            supprimer_employe frm = new supprimer_employe();
            frm.ShowDialog();
        }
    }
}
