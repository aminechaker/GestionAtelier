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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

        private void EmployePictureBox_MouseHover(object sender, EventArgs e)
        {
            //EmployePictureBox.Image = Resources.employe1;
        }

        private void EmployePictureBox_MouseLeave(object sender, EventArgs e)
        {
            //EmployePictureBox.Image = Resources.employe;
        }

        private void FonctionPictureBox_MouseHover(object sender, EventArgs e)
        {
            //FonctionPictureBox.Image = Resources.fonction1;
        }

        private void FonctionPictureBox_MouseLeave(object sender, EventArgs e)
        {
            //FonctionPictureBox.Image = Resources.fonction;
        }

        private void PointagePictureBox_MouseHover(object sender, EventArgs e)
        {
            //PointagePictureBox.Image = Resources.pointage1;
        }

        private void PointagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            //PointagePictureBox.Image = Resources.pointage;
        }

        private void AvancePictureBox_MouseHover(object sender, EventArgs e)
        {
            //AvancePictureBox.Image = Resources.avance1;
        }

        private void AvancePictureBox_MouseLeave(object sender, EventArgs e)
        {
            //AvancePictureBox.Image = Resources.avance;
        }

        private void SalairePictureBox_MouseHover(object sender, EventArgs e)
        {
            //SalairePictureBox.Image = Resources.salaire1;
        }

        private void SalairePictureBox_MouseLeave(object sender, EventArgs e)
        {
            //SalairePictureBox.Image = Resources.salaire;
        }      

        private void ArticlePictureBox_MouseHover(object sender, EventArgs e)
        {
            //ArticlePictureBox.Image = Resources.article1;
        }

        private void ArticlePictureBox_MouseLeave(object sender, EventArgs e)
        {
            //ArticlePictureBox.Image = Resources.article;
        }

        private void QuitterPictureBox_MouseHover(object sender, EventArgs e)
        {
            //QuitterPictureBox.Image = Resources.quitter1;
        }

        private void QuitterPictureBox_MouseLeave(object sender, EventArgs e)
        {
            //QuitterPictureBox.Image = Resources.quitter;
        }

        private void QuitterPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployePictureBox_Click(object sender, EventArgs e)
        {
            employes frm = new employes();
            frm.ShowDialog();
        }

        private void FonctionPictureBox_Click(object sender, EventArgs e)
        {
            fonctions frm = new fonctions();
            frm.ShowDialog();
        }

        private void PointagePictureBox_Click(object sender, EventArgs e)
        {
            pointage frm = new pointage();
            frm.ShowDialog();
        }

        private void AvancePictureBox_Click(object sender, EventArgs e)
        {
            avance frm = new avance();
            frm.ShowDialog();
        }

        private void SalairePictureBox_Click(object sender, EventArgs e)
        {
            salaire frm = new salaire();
            frm.ShowDialog();
        }

        private void ArticlePictureBox_Click(object sender, EventArgs e)
        {
            article frm = new article();
            frm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employes frm = new employes();
            frm.ShowDialog();
        }

        private void bntAvance_Click(object sender, EventArgs e)
        {
            avance frm = new avance();
            frm.ShowDialog();
        }

        private void bntSalaire_Click(object sender, EventArgs e)
        {
            salaire frm = new salaire();
            frm.ShowDialog();
        }

        private void bntArticle_Click(object sender, EventArgs e)
        {
            article frm = new article();
            frm.ShowDialog();
        }

        private void btnFonction_Click(object sender, EventArgs e)
        {
            fonctions frm = new fonctions();
            frm.ShowDialog();
        }

        private void btnPointage_Click(object sender, EventArgs e)
        {
            pointage frm = new pointage();
            frm.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            btnEmployee.BackColor = Color.Blue;
        }

        private void btnEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            btnEmployee.ForeColor = Color.Gray;
            btnEmployee.Appearance.FontSizeDelta = 7;
        }

        private void btnEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmployee.ResetForeColor();
            btnEmployee.Appearance.FontSizeDelta = 0;
        }

        private void btnFonction_MouseMove(object sender, MouseEventArgs e)
        {
            btnFonction.ForeColor = Color.Gray;
            btnFonction.Appearance.FontSizeDelta = 7;
        }

        private void btnFonction_MouseLeave(object sender, EventArgs e)
        {
            btnFonction.ResetForeColor();
            btnFonction.Appearance.FontSizeDelta = 0;
        }

        private void btnPointage_MouseMove(object sender, MouseEventArgs e)
        {
            btnPointage.ForeColor = Color.Gray;
            btnPointage.Appearance.FontSizeDelta = 7;
        }

        private void btnPointage_MouseLeave(object sender, EventArgs e)
        {
            btnPointage.ResetForeColor();
            btnPointage.Appearance.FontSizeDelta = 0;
        }

        private void bntAvance_MouseLeave(object sender, EventArgs e)
        {
            bntAvance.ResetForeColor();
            bntAvance.Appearance.FontSizeDelta = 0;
        }

        private void bntAvance_MouseMove(object sender, MouseEventArgs e)
        {
            bntAvance.ForeColor = Color.Gray;
            bntAvance.Appearance.FontSizeDelta = 7;   
        }

        private void bntSalaire_MouseLeave(object sender, EventArgs e)
        {
            bntSalaire.ResetForeColor();
            bntSalaire.Appearance.FontSizeDelta = 0;
        }

        private void bntSalaire_MouseMove(object sender, MouseEventArgs e)
        {
            bntSalaire.ForeColor = Color.Gray;
            bntSalaire.Appearance.FontSizeDelta = 7;         
        }

        private void bntArticle_MouseLeave(object sender, EventArgs e)
        {
            bntArticle.ResetForeColor();
            bntArticle.Appearance.FontSizeDelta = 0;
        }

        private void bntArticle_MouseMove(object sender, MouseEventArgs e)
        {
            bntArticle.ForeColor = Color.Gray;
            bntArticle.Appearance.FontSizeDelta = 7;
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.ResetForeColor();
            btnQuitter.Appearance.FontSizeDelta = 0;
        }

        private void btnQuitter_MouseMove(object sender, MouseEventArgs e)
        {
            btnQuitter.ForeColor = Color.Red;
            btnQuitter.Appearance.FontSizeDelta = 4;
        }
    }
}
