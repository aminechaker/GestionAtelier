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
    public partial class fonctions : Form
    {
        public fonctions()
        {
            InitializeComponent();
        }

        private void AjouterFonctionPictureBox_MouseHover(object sender, EventArgs e)
        {
            AjouterFonctionPictureBox.Image = Resources.ajouter_fonction1;
        }

        private void AjouterFonctionPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AjouterFonctionPictureBox.Image = Resources.ajouter_fonction;
        }

        private void ListeDesFonctionPictureBox_MouseHover(object sender, EventArgs e)
        {
            ListeDesFonctionPictureBox.Image = Resources.liste_fonction1;
        }

        private void ListeDesFonctionPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListeDesFonctionPictureBox.Image = Resources.liste_fonction;
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterFonctionPictureBox_Click(object sender, EventArgs e)
        {
            ajouter_fonction frm = new ajouter_fonction();
            frm.ShowDialog();
        }

        private void ListeDesFonctionPictureBox_Click(object sender, EventArgs e)
        {
            liste_fonctions frm = new liste_fonctions();
            frm.ShowDialog();
        }
    }
}
