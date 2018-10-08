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
    public partial class salaire : Form
    {
        public salaire()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculerSalairePictureBox_MouseHover(object sender, EventArgs e)
        {
            CalculerSalairePictureBox.Image = Resources.calculer_salaire1;
        }

        private void CalculerSalairePictureBox_MouseLeave(object sender, EventArgs e)
        {
            CalculerSalairePictureBox.Image = Resources.calculer_salaire;
        }

        private void ListeDesSalairePictureBox_MouseHover(object sender, EventArgs e)
        {
            ListeDesSalairePictureBox.Image = Resources.liste_salaire1;
        }

        private void ListeDesSalairePictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListeDesSalairePictureBox.Image = Resources.liste_salaire;
        }

        private void CalculerSalairePictureBox_Click(object sender, EventArgs e)
        {
            calculer_salaire frm = new calculer_salaire();
            frm.ShowDialog();
        }

        private void ListeDesSalairePictureBox_Click(object sender, EventArgs e)
        {
            list_salaire frm = new list_salaire();
            frm.ShowDialog();
        }
    }
}
