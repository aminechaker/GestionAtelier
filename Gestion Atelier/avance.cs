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
    public partial class avance : Form
    {
        public avance()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterAvancePictureBox_MouseHover(object sender, EventArgs e)
        {
            AjouterAvancePictureBox.Image = Resources.ajouter_avance1;
        }

        private void AjouterAvancePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AjouterAvancePictureBox.Image = Resources.ajouter_avance;
        }

        private void ListeDesAvancesPictureBox_MouseHover(object sender, EventArgs e)
        {
            ListeDesAvancesPictureBox.Image = Resources.liste_avance1;
        }

        private void ListeDesAvancesPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListeDesAvancesPictureBox.Image = Resources.liste_avance;
        }

        private void AjouterAvancePictureBox_Click(object sender, EventArgs e)
        {
            ajouter_avance frm = new ajouter_avance();
            frm.ShowDialog();
        }

        private void ListeDesAvancesPictureBox_Click(object sender, EventArgs e)
        {
            liste_avance frm = new liste_avance();
            frm.ShowDialog();
        }
    }
}
