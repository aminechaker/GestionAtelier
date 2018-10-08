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
    public partial class article : Form
    {
        public article()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterArticlePictureBox_MouseHover(object sender, EventArgs e)
        {
            AjouterArticlePictureBox.Image = Resources.ajouter_article1;
        }

        private void AjouterArticlePictureBox_MouseLeave(object sender, EventArgs e)
        {
            AjouterArticlePictureBox.Image = Resources.ajouter_article;
        }

        private void ListeArticlePictureBox_MouseHover(object sender, EventArgs e)
        {
            ListeArticlePictureBox.Image = Resources.liste_article1;
        }

        private void ListeArticlePictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListeArticlePictureBox.Image = Resources.liste_article;
        }

        private void AjouterArticlePictureBox_Click(object sender, EventArgs e)
        {
            ajouter_article frm = new ajouter_article();
            frm.ShowDialog();
        }

        private void ListeArticlePictureBox_Click(object sender, EventArgs e)
        {
            list_article frm = new list_article();
            frm.ShowDialog();
        }
    }
}
