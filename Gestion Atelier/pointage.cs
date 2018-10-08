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
    public partial class pointage : Form
    {
        public pointage()
        {
            InitializeComponent();
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PointageDuJourPictureBox_MouseHover(object sender, EventArgs e)
        {
            PointageDuJourPictureBox.Image = Resources.pointage_du_jour1;
        }

        private void PointageDuJourPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PointageDuJourPictureBox.Image = Resources.pointage_du_jour;
        }

        private void PointageManuelPictureBox_MouseHover(object sender, EventArgs e)
        {
            PointageManuelPictureBox.Image = Resources.pointage_manuel1;
        }

        private void PointageManuelPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PointageManuelPictureBox.Image = Resources.pointage_manuel;
        }

        private void ModifierPointagePictureBox_MouseHover(object sender, EventArgs e)
        {
            ModifierPointagePictureBox.Image = Resources.modifier_pointage1;
        }

        private void ModifierPointagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            ModifierPointagePictureBox.Image = Resources.modifier_pointage;
        }

        private void ListPointagePictureBox_MouseHover(object sender, EventArgs e)
        {
            ListPointagePictureBox.Image = Resources.list_pointage1;
        }

        private void ListPointagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            ListPointagePictureBox.Image = Resources.list_pointage;
        }

        private void PointageDuJourPictureBox_Click(object sender, EventArgs e)
        {
            pointage_du_jour frm = new pointage_du_jour();
            frm.ShowDialog();
        }

        private void ModifierPointagePictureBox_Click(object sender, EventArgs e)
        {
            modifier_pointage frm = new modifier_pointage();
            frm.ShowDialog();
        }

        private void PointageManuelPictureBox_Click(object sender, EventArgs e)
        {
            pointage_manuellement frm = new pointage_manuellement();
            frm.ShowDialog();
        }

        private void ListPointagePictureBox_Click(object sender, EventArgs e)
        {
            list_pointage frm = new list_pointage();
            frm.ShowDialog();
        }
    }
}
